using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace iTunesCOMSample
{
    public partial class BrowserAdmin : Form
    {


        public BrowserAdmin()
        {
            InitializeComponent();

            Common.StatusUpdate += Common_StatusUpdate;
        }

        void Common_StatusUpdate(object sender, StatusUpdateEventArgs e)
        {
            UpdateStatus(e.Message);
        }

        void UpdateStatus(string message)
        {
            status.Text = message;
            Refresh();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            explorerBrowser.Navigate((ShellObject)KnownFolders.Desktop);
        }

        private void startMissingAlbum_Click(object sender, EventArgs e)
        {
            //go through all folders off root (artist)
            //look at each sub folder (album)
            //if album.jpg does not exist, set explorer window and clipboard value
            DirectoryInfo di = new DirectoryInfo(Settings.PreferredRootPath);
            StartMissingAlbumJpgSearch(di.GetDirectories());
        }

        private void SetExplorerFolder(string path)
        {
            try
            {
                // navigate to specific folder
                explorerBrowser.Navigate(ShellFileSystemFolder.FromFolderPath(path));
            }
            catch (COMException)
            {
                MessageBox.Show("Navigation not possible.");
            }
        }
        

        private void StartMissingAlbumJpgSearch(IEnumerable<string> starredArtists)
        {
            List<DirectoryInfo> directoryInfos = new List<DirectoryInfo>();

            foreach (string artist in starredArtists)
            {
                if (!IsComStringNull(artist))
                {
                    string path = string.Concat(Settings.PreferredRootPath, "\\", artist);

                    if (Directory.Exists(path))
                    {
                        directoryInfos.Add(new DirectoryInfo(path));
                    }
                }
            }

            StartMissingAlbumJpgSearch(directoryInfos.ToArray());
        }

        private bool IsComStringNull(string v)
        {
            //while it appears this is a string, if coming from iTunes COM, it may in fact be null and not detectable until you try to manipulate it. 
            try
            {
                v.ToString();
                return false;
            }
            catch(NullReferenceException)
            {
                return true;
            }
        }


        private void StartMissingAlbumJpgSearch(DirectoryInfo[] d)
        {
            artistFolders = d;
            artistFolderIndex = 0;
            albumFolders = artistFolders[0].GetDirectories();
            albumFolderIndex = 0;

            GetNextMissingAlbumJpgFolder();
        }

        private void GetNextMissingAlbumJpgFolder()
        {
            bool keepLooking = true;

            while (keepLooking)
            {
                if(albumFolderIndex < albumFolders.Length)
                {
                    var x = albumFolders[albumFolderIndex];
                    if(x.GetFiles("Album.jpg", SearchOption.TopDirectoryOnly).Length == 0)
                    {
                        keepLooking = false;
                        albumFolderIndex++;

                        SetExplorerFolder(x.FullName);
                        Clipboard.SetText(string.Format("{0} {1}", x.Parent.Name, x.Name));
                    }
                    else
                    {
                        albumFolderIndex++;
                    }
                }
                else
                { 
                    //move to next artist
                    artistFolderIndex++;

                    if (artistFolderIndex < artistFolders.Length)
                    {
                        albumFolders = artistFolders[artistFolderIndex].GetDirectories();
                        albumFolderIndex = 0;
                    }
                    else
                    {
                        //we're done
                        keepLooking = false;
                    }
                }
            }

            //need status to say complete
        }

        private DirectoryInfo[] artistFolders;
        private int artistFolderIndex;
        private DirectoryInfo[] albumFolders;
        private int albumFolderIndex;

        private void nextMissingAlbum_Click(object sender, EventArgs e)
        {
            GetNextMissingAlbumJpgFolder();
        }

        private void explorerBrowser_SelectionChanged(object sender, EventArgs e)
        {
            if (renameDraggedFile.Checked && explorerBrowser.SelectedItems.Count == 1)
            {
                //check to see if it is a jpg that fits the pattern, and if we want to rename
                
                
                // this does not work: var file = explorerBrowser.SelectedItems[0];
                //for some reason, this will return the name, doing file.Name returns "Computer"
                FileInfo selectedFile = new FileInfo(explorerBrowser.SelectedItems[0].ParsingName);

                //needed as multiple selection change calls can occur, and the old name may persist...
                if (selectedFile.Exists)
                {
                    Common.FixAlbumNameAndUpdateFolderMp3Metadata(selectedFile, !renameDraggedFile.Checked);
                }
            }
        }


        private void updateFileMetadata_Click(object sender, EventArgs e)
        {
            //not sure how needed this is anymore, does the same thing as part of what is now in dropping a jpg into the folder
            for (int i = 0; i < explorerBrowser.SelectedItems.Count; i++ )
            {
                FileInfo selectedFile = new FileInfo(explorerBrowser.SelectedItems[i].ParsingName);

                Common.UpdateMp3Metadata(selectedFile.FullName, updateItunes.Checked);
            }
        }

        private void startMissingFiveStar_Click(object sender, EventArgs e)
        {
            // get list of all 5 star artists, build up list 


            var starredArtists = (from tracks in Common.ITunesMusicTracks
                                  where tracks.Rating >= 60
                                  orderby tracks.Artist
                                  select tracks.Artist).ToList().Distinct();

            StartMissingAlbumJpgSearch(starredArtists);
        }

        

        private void startRecent_Click(object sender, EventArgs e)
        {
            var starredArtists = (from tracks in Common.ITunesMusicTracks
                                  where tracks.DateAdded >= DateTime.Parse("1/1/2014")
                                  orderby tracks.Artist
                                  select tracks.Artist).ToList().Distinct();

            StartMissingAlbumJpgSearch(starredArtists);
        }

    }
}
