using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTunesLib;
using System.IO;

namespace iTunesCOMSample
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            //TODO: at some point save this data off to registry or something....
            Settings.LegacyRootPath = legacyRootPath.Text;
            Settings.PreferredRootPath = newRootPath.Text;

            Common.StatusUpdate += Common_StatusUpdate;
        }

        void Common_StatusUpdate(object sender, StatusUpdateEventArgs e)
        {
            UpdateStatus(e.Message);
        }

        void UpdateStatus(string message)
        {
            status.Text = message + "\r\n" + status.Text;
            Refresh();
        }

        private void updateMp3Metadata_Click(object sender, EventArgs e)
        {
            UpdateStatus("Start: Update MP3 Album Metadata");
            string rootFolder = Settings.PreferredRootPath;
            DirectoryInfo di = new DirectoryInfo(rootFolder);
            
            foreach (var file in di.EnumerateFiles("*.mp3", SearchOption.AllDirectories))
            {
                UpdateStatus("Updating MetaData: " + file.FullName);

                if (!testOnly.Checked)
                {
                    Common.UpdateMp3Metadata(file.FullName,true);
                }
            }
            UpdateStatus("Complete: Update MP3 Album Metadata");
        }


        private void updateLocation_Click(object sender, EventArgs e)
        {
            string fromPath = Settings.LegacyRootPath;
            string toPath = Settings.PreferredRootPath;

            var selectedTracks = (from tracks in Common.GetITunesTracks()
                                  where tracks.Genre != "Podcast"
                                  && tracks.Location != string.Empty
                                  && tracks.Location.StartsWith(fromPath)
                                  select tracks).Take(250);

            if (testOnly.Checked)
                UpdateStatus("--------------------------------------------------- TEST ONLY ---------------------------------------------------");

            resultsGrid.DataSource = selectedTracks.Select(t => new { t.Name, t.Artist, t.Location, t.Genre, Rating = (t.Rating / 20), t.PlayedDate, t.PlayedCount, t.Enabled, t.TrackDatabaseID }).ToList();

            UpdateStatus("Bulk Update File Location: Started");
            UpdateStatus(string.Format("Changing Path from {0} to {1}", fromPath, toPath));

            foreach (var track in selectedTracks)
            {
                UpdateStatus(string.Format("Root Path Change: " + track.Location));

                if (!testOnly.Checked)
                    track.Location = track.Location.Replace(fromPath, toPath);
            }

            UpdateStatus("Bulk Update File Location: Complete");
        }
        
        private void removeUnchecked_Click(object sender, EventArgs e)
        {
            var selectedTracks = (from tracks in Common.ITunesMusicTracks
                                  where tracks.Enabled.Equals(false)
                                  && tracks.Location.ToLower().EndsWith(".mp3")
                                  orderby tracks.trackID descending
                                  select tracks).Take(100);

            if (testOnly.Checked)
            {
                resultsGrid.DataSource = selectedTracks.Select(t => new { t.Name, t.Artist, t.Location, t.Genre, Rating = (t.Rating / 20), t.PlayedDate, t.PlayedCount, t.Enabled, t.trackID, t.sourceID, t.playlistID, t.TrackDatabaseID }).ToList();
            }
            else
            {
                status.Text = "Removing unchecked tracks";

                foreach (var track in selectedTracks)
                {
                    try
                    {
                        DeleteTrackFromItunesAndDisk(track);
                    }
                    catch (Exception)
                    {
                        UpdateStatus("error deleting track, reload data");
                        testOnly.Checked = true;
                        return;
                    }
                }
            }
            //always reset to test after an action
            testOnly.Checked = true;
        }

        private void DeleteTrackFromItunesAndDisk(IITFileOrCDTrack track)
        {
            UpdateStatus("Removing: " + track.Location);
            string path = track.Location;
            //Common.ITunesMusicTracks.Remove(track);
            track.Delete();
            File.Delete(path);
        }

        private void listMusicInItunes_Click(object sender, EventArgs e)
        {
            UpdateStatus("List Music in iTunes: Started");

            var selectedTracks = (from tracks in Common.ITunesMusicTracks
                                  orderby tracks.Location
                                  select tracks);

            resultsGrid.DataSource = selectedTracks.Select(t => new { t.Name, t.Artist, t.Location, t.Genre, Rating = (t.Rating / 20), t.PlayedDate, t.PlayedCount, ArtworkExists = (t.Artwork.Count == 1), t.Enabled, t.TrackDatabaseID }).ToList();

            UpdateStatus("List Music in iTunes: Complete");
        }

        private void listFilesNotInItunes_Click(object sender, EventArgs e)
        {
            //get all file paths in iTunes
            //get all mp3 files
            //list files not found in iTunes

            string rootFolders = string.Concat(Settings.LegacyRootPath, ";", Settings.PreferredRootPath);
            //string rootFolders = @"C:\Users\Public\Music\Artists; C:\Users\Public\Music\iTunes Controlled; C:\Users\Public\Music\Mashups";
            char[] separator = new char[] { ';' };

            status.Text = string.Format("Searching {0} for mp3's not in iTunes", rootFolders);

            var knownFileTracks = (from tracks in Common.GetITunesTracks()
                                   where tracks.Location.ToLower().EndsWith(".mp3")
                                   orderby tracks.Location
                                   select new { tracks.Location }).ToList();

            resultsGrid.DataSource = knownFileTracks;
            foreach (string folder in rootFolders.Split(separator))
            {
                DirectoryInfo di = new DirectoryInfo(folder.Trim());

                foreach (var file in di.GetFiles("*.mp3", SearchOption.AllDirectories))
                {
                    if (!knownFileTracks.Any(t => t.Location.ToLower() == file.FullName.ToLower()))
                    {
                        status.Text = string.Format("Delete: {0}\r\n{1}", file.FullName, status.Text);
                    }
                    else
                    {
                        //status.Text = string.Format("MATCH: {0}\r\n{1}", file.FullName, status.Text);
                    }
                }
            }
        }

        private void deleteImageFiles_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("This will delete all system generated files from folders in " + Settings.LegacyRootPath + " \r\nProceed?", "", MessageBoxButtons.YesNo);

            if (response == System.Windows.Forms.DialogResult.Yes)
            {
                if (testOnly.Checked)
                    UpdateStatus("--------------------------------------------------- TEST ONLY ---------------------------------------------------");

                UpdateStatus("Delete Image Files: Started");

                Common.DeleteFiles(Settings.LegacyRootPath, "AlbumArt*.jpg", testOnly.Checked);
                Common.DeleteFiles(Settings.LegacyRootPath, "Folder.jpg", testOnly.Checked);
                Common.DeleteFiles(Settings.LegacyRootPath, "desktop.ini", testOnly.Checked);

                UpdateStatus("Delete Image Files: Complete");
            }
        }

        private void albumRenameReset_Click(object sender, EventArgs e)
        {
            string rootFolder = Settings.PreferredRootPath;
            DirectoryInfo di = new DirectoryInfo(rootFolder);

            if (testOnly.Checked)
                UpdateStatus("--------------------------------------------------- TEST ONLY ---------------------------------------------------");

            UpdateStatus("Album Rename Reset: Started");

            foreach (var file in di.GetFiles("MI*.jpg", SearchOption.AllDirectories))
            {
                UpdateStatus(string.Format("Renaming: {0} - {1}\r\n{2}", file.FullName, file.DirectoryName + "\\Album.jpg", status.Text));

                if (!testOnly.Checked)
                {
                    File.Move(file.FullName, file.DirectoryName + "\\Album.jpg");
                }
            }

            UpdateStatus("Album Rename Reset: Complete");
        }

        private void listFiles_Click(object sender, EventArgs e)
        {
            UpdateStatus("List Music in iTunes: Started");

            var selectedTracks = (from tracks in Common.ITunesMusicTracks
                                  orderby tracks.Location
                                  select tracks);

            resultsGrid.DataSource = selectedTracks.Select(t => new { t.Name, t.Artist, t.Location, t.Genre, Rating = (t.Rating / 20), t.PlayedDate, t.PlayedCount, ArtworkExists = (t.Artwork.Count == 1), t.Enabled, t.TrackDatabaseID }).ToList();

            UpdateStatus("List Music in iTunes: Complete");
        }

        private void listItunesControlledSongs_Click(object sender, EventArgs e)
        {
            string fromPath = Settings.LegacyRootPath;

            UpdateStatus("List Music in iTunes Legacy Root: Started");

            try
            {
                var selectedTracks = (from tracks in Common.ITunesMusicTracks
                                      where tracks.Location.ToLower().StartsWith(fromPath.ToLower())
                                      orderby tracks.Location
                                      select tracks);

                resultsGrid.DataSource = selectedTracks.Select(t => new { t.Name, t.Artist, t.Location, t.Genre, Rating = (t.Rating / 20), t.PlayedDate, t.PlayedCount, ArtworkExists = (t.Artwork.Count == 1), t.Enabled, t.TrackDatabaseID }).ToList();

                UpdateStatus("List Music in iTunes Legacy Root: Complete");
            }
            catch
            {
                UpdateStatus("Error Occured, chances are it is a null location, Click List All Music to see");
            }
        }


        private void SetSelectedTrackValues(int trackDatabaseID)
        {
            try
            {
                var iTunesFile = Common.ITunesMusicTracks.Find(t => t.TrackDatabaseID == trackDatabaseID);
                UpdateStatus("Selected: " + iTunesFile.Name);
                selectedAlbum.Text = iTunesFile.Album;
                selectedArtist.Text = iTunesFile.Artist;
                selectedTrack.Text = iTunesFile.Name;
                selectedYear.Text = iTunesFile.Year.ToString();
                selectedTrackNumber.Text = iTunesFile.TrackNumber.ToString();
                selectedArtwork.Text = (iTunesFile.Artwork.Count == 1).ToString();

                if (File.Exists(iTunesFile.Location))
                {
                    FileInfo fi = new FileInfo(iTunesFile.Location);
                    selectedAlbumImageExist.Text = (File.Exists(fi.DirectoryName + "\\Album.jpg")).ToString();
                }
            }
            catch(Exception)
            {
                UpdateStatus("an error occured setting selected track values");
            }
        }

        private void SaveTrackValues(int trackDatabaseID)
        {
            var iTunesFile = Common.ITunesMusicTracks.Find(t => t.TrackDatabaseID == trackDatabaseID);
            UpdateStatus("Saving: " + iTunesFile.Name);
            iTunesFile.Album = selectedAlbum.Text;
            iTunesFile.SortAlbum = "";
            iTunesFile.Artist = selectedArtist.Text;
            iTunesFile.AlbumArtist = "";
            iTunesFile.SortAlbumArtist = "";
            iTunesFile.Name = selectedTrack.Text;
            iTunesFile.Year = int.Parse(selectedYear.Text);
            iTunesFile.TrackNumber = int.Parse(selectedTrackNumber.Text);
            iTunesFile.Compilation = false;
            iTunesFile.TrackCount = 0;
            iTunesFile.DiscCount = 0;
            iTunesFile.DiscNumber = 0;
        }

        private int selectedTrackDatabaseID;

        private void resultsGrid_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = resultsGrid.HitTest(e.X, e.Y).RowIndex;

            if (currentMouseOverRow >= 0)
            {
                //update details panel
                if (resultsGrid.SelectedRows.Count == 1)
                {
                    int trackDatabaseID = int.Parse(resultsGrid.SelectedRows[0].Cells["TrackDatabaseID"].Value.ToString());

                    //since this is called on every mouse click, it re-loads this data alot, including trying to load after deleted
                    if(trackDatabaseID != selectedTrackDatabaseID)
                    {
                        selectedTrackDatabaseID = trackDatabaseID;
                        SetSelectedTrackValues(selectedTrackDatabaseID);
                    }
                }
                
                if(e.Button == MouseButtons.Left)
                {

                }

                if (e.Button == MouseButtons.Right)
                {
                    ContextMenu m = new ContextMenu();

                    var mi1 = new MenuItem();
                    mi1.Text = "Move: Selected Row(s)";
                    mi1.Name = "MoveSelectedRows";
                    mi1.Click += moveSelectedRows_Click;
                    m.MenuItems.Add(mi1);

                    var mi2 = new MenuItem();
                    mi2.Text = "Update Metadata: Selected Row(s)";
                    mi2.Name = "UpdateMetadataSelectedRows";
                    mi2.Click += updateMetadataSelectedRows_Click;
                    m.MenuItems.Add(mi2);

                    var mi3 = new MenuItem();
                    mi3.Text = "Open Windows Explorer";
                    mi3.Name = "OpenWindowsExplorer";
                    mi3.Click += openWindowsExplorer_Click;
                    m.MenuItems.Add(mi3);

                    var mi4 = new MenuItem();
                    mi4.Text = "If unchecked, Remove Selected Row(s)";
                    mi4.Name = "OpenWindowsExplorer";
                    mi4.Click += removeSelectedRows_Click;
                    m.MenuItems.Add(mi4);

                    m.Show(resultsGrid, new Point(e.X, e.Y));
                }
            }

        }

        private void resultsGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = resultsGrid.HitTest(e.X, e.Y).RowIndex;

            if (currentMouseOverRow >= 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    var track = Common.ITunesMusicTracks.Where(t => t.TrackDatabaseID == selectedTrackDatabaseID).FirstOrDefault();
                    //need to stop playing if updating the location of the file...
                    track.Reveal();
                    track.Play();
                }
            }
        }

        private void openWindowsExplorer_Click(object sender, EventArgs e)
        {
            string selectedFilePath = Common.ITunesMusicTracks.Where(t => t.TrackDatabaseID == selectedTrackDatabaseID).FirstOrDefault().Location;
            System.Diagnostics.Process.Start("explorer.exe", string.Format("/select,\"{0}\"", selectedFilePath));
        }

        private void moveSelectedRows_Click(object sender, EventArgs e)
        {
            if (testOnly.Checked)
                UpdateStatus("--------------------------------------------------- TEST ONLY ---------------------------------------------------");

            UpdateStatus("Move File: Started");

            //write this is a test only
            foreach (DataGridViewRow row in resultsGrid.SelectedRows)
            {
                var trackDatabaseID = int.Parse(row.Cells["TrackDatabaseID"].Value.ToString());
                var iTunesFile = Common.ITunesMusicTracks.Find(t => t.TrackDatabaseID == trackDatabaseID);

                Common.MoveITunesFile(iTunesFile, Settings.PreferredRootPath, testOnly.Checked);
            }

            UpdateStatus("Move File: Complete");
        }

        private void updateMetadataSelectedRows_Click(object sender, EventArgs e)
        {
            if (testOnly.Checked)
                UpdateStatus("--------------------------------------------------- TEST ONLY ---------------------------------------------------");

            UpdateStatus("Update Metadata: Started");

            //write this is a test only
            foreach (DataGridViewRow row in resultsGrid.SelectedRows)
            {
                var trackDatabaseID = int.Parse(row.Cells["TrackDatabaseID"].Value.ToString());
                var iTunesFile = Common.ITunesMusicTracks.Find(t => t.TrackDatabaseID == trackDatabaseID);

                Common.UpdateMp3Metadata(iTunesFile.Location, testOnly.Checked);
            }

            UpdateStatus("Update Metadata: Complete");
        }

        private void removeSelectedRows_Click(object sender, EventArgs e)
        {
            if (testOnly.Checked)
                UpdateStatus("--------------------------------------------------- TEST ONLY ---------------------------------------------------");

            UpdateStatus("If unchecked, Remove Selected Row(s): Started");


            foreach (DataGridViewRow row in resultsGrid.SelectedRows)
            {
                try
                {
                    int trackDatabaseID = int.Parse(row.Cells["TrackDatabaseID"].Value.ToString());
                    var iTunesFile = Common.ITunesMusicTracks.Find(t => t.TrackDatabaseID == trackDatabaseID);

                    if (!iTunesFile.Enabled)
                    {
                        if (testOnly.Checked)
                        {
                            UpdateStatus("TEST Removed: " + iTunesFile.Location);
                        }
                        else
                        {
                            DeleteTrackFromItunesAndDisk(iTunesFile);
                        }
                    }
                    else
                    {
                        UpdateStatus("Enabled: " + iTunesFile.Location);
                    }
                }
                catch(Exception ex)
                {
                    UpdateStatus("error occured: " + ex.Message);
                }

            }


            UpdateStatus("If unchecked, Remove Selected Row(s): Complete");
        }

        private void deleteEmptyFolders_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("This will delete all empty folders from " + Settings.PreferredRootPath + " \r\nProceed?", "", MessageBoxButtons.YesNo);

            if (response == System.Windows.Forms.DialogResult.Yes)
            {
                if (testOnly.Checked)
                    UpdateStatus("--------------------------------------------------- TEST ONLY ---------------------------------------------------");

                UpdateStatus("Delete Empty Folders: Started");

                Common.DeleteEmptyDirectories(Settings.PreferredRootPath, testOnly.Checked);

                UpdateStatus("Delete Empty Folders: Complete");
            }
        }

        private void clearStatus_Click(object sender, EventArgs e)
        {
            status.Text = "";
        }

        private void missingAlbum_Click(object sender, EventArgs e)
        {
            (new BrowserAdmin()).ShowDialog();
        }

        private void legacyRootPath_TextChanged(object sender, EventArgs e)
        {
            Settings.LegacyRootPath = legacyRootPath.Text;
        }

        private void newRootPath_TextChanged(object sender, EventArgs e)
        {
            Settings.PreferredRootPath = newRootPath.Text;
        }

        private void loadItunesTracks_Click(object sender, EventArgs e)
        {
            UpdateStatus("Start: Reloading of ITunes Music Tracks");
            Common.ReloadITunesMusicTracks();
            UpdateStatus("Complete: Reloading of ITunes Music Tracks");
        }

        private void listMusicWithoutArtwork_Click(object sender, EventArgs e)
        {
            UpdateStatus("List Music without Artwork: Started");

            var selectedTracks = (from tracks in Common.ITunesMusicTracks
                                  where tracks.Artwork.Count == 0
                                  orderby tracks.Location
                                  select tracks);

            resultsGrid.DataSource = selectedTracks.Select(t => new { t.Name, t.Artist, t.Location, t.Genre, Rating = (t.Rating / 20), t.PlayedDate, t.PlayedCount, ArtworkExists = (t.Artwork.Count == 1), t.Enabled, t.TrackDatabaseID }).ToList();

            UpdateStatus("List Music without Artwork: Complete");

        }

        private void saveSelected_Click(object sender, EventArgs e)
        {
            SaveTrackValues(selectedTrackDatabaseID);

            var track = Common.ITunesMusicTracks.Where( t => t.TrackDatabaseID == selectedTrackDatabaseID).FirstOrDefault();
            Common.MoveITunesFile(track, Settings.PreferredRootPath, false);

        }

        private void starredArtists_Click(object sender, EventArgs e)
        {

            var starredArtists = (from tracks in Common.ITunesMusicTracks
                                  where tracks.Rating == 100
                                  orderby tracks.Artist
                                  select tracks.Artist).ToList().Distinct();

            foreach(var artist in starredArtists)
            {
                UpdateStatus(artist);
            }
        }

    }
}
