using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using iTunesLib;

namespace iTunesCOMSample
{
    public class Common
    {

        protected static void OnStatusUpdate(string message)
        {
            var args = new StatusUpdateEventArgs();
            args.Message = message;

            OnStatusUpdate(args);
        }

        protected static void OnStatusUpdate(StatusUpdateEventArgs e)
        {
            EventHandler<StatusUpdateEventArgs> handler = StatusUpdate;
            if (handler != null)
            {
                handler(null, e);
            }
        }

        public static event EventHandler<StatusUpdateEventArgs> StatusUpdate;

        public static void UpdateMp3Metadata(string filePath, bool updateITunes)
        {
            OnStatusUpdate("Updating metadata: " + filePath);

            TagLib.File f = TagLib.File.Create(filePath);

            //check if album.jpg exists
            //if so, reset pictures array with it
            string albumPath = Path.GetDirectoryName(filePath) + "\\Album.jpg";

            if (File.Exists(albumPath))
            {
                //trying to do the following will not work for iTunes: TagLib.Picture cover = new TagLib.Picture(albumPath);
                //additional info here http://stackoverflow.com/questions/13667378/embed-album-art-in-mp3-using-tag-lib-c-sharp

                TagLib.Id3v2.AttachedPictureFrame pic = new TagLib.Id3v2.AttachedPictureFrame();
                pic.TextEncoding = TagLib.StringType.Latin1;
                pic.MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg;
                pic.Type = TagLib.PictureType.FrontCover;
                pic.Data = TagLib.ByteVector.FromPath(albumPath);

                f.Tag.Pictures = new TagLib.IPicture[1] { pic };

                f.Save();
            }
            //

            //clear composer, comments

            //check for "various artists"

            //if update iTunes is checked, then update iTunes
            if (updateITunes)
            {
                var iTunesFile = ITunesMusicTracks.Where(t => t.Location.ToLower() == filePath.ToLower()).FirstOrDefault();
                iTunesFile.UpdateInfoFromFile();
            }
        }


        public static void FixAlbumNameAndUpdateFolderMp3Metadata(FileInfo selectedFile, bool testOnly)
        {
            bool selectedFileIsCoverJpg = false;

            //http://allmusic.com image file names are of the pattern MI<number>.jpg
            if (selectedFile.Name.ToLower().StartsWith("mi") && selectedFile.Name.ToLower().EndsWith(".jpg"))
                selectedFileIsCoverJpg = true;

            //http://www.discogs.com/ image file names are of the pattern R-<number>-<another number>.jpeg.jpg
            if (selectedFile.Name.ToLower().StartsWith("r") && selectedFile.Name.ToLower().EndsWith(".jpeg.jpg"))
                selectedFileIsCoverJpg = true;



            if(selectedFileIsCoverJpg)
            {
                OnStatusUpdate("Renaming: " + selectedFile.FullName + " to Album.jpg");

                if (!testOnly)
                {
                    File.Move(selectedFile.FullName, selectedFile.DirectoryName + "\\Album.jpg");
                }

                //get all mp3 files in folder
                foreach (var f in Directory.EnumerateFiles(selectedFile.DirectoryName, "*.mp3"))
                {
                    if (!testOnly)
                    {
                        UpdateMp3Metadata(f, !testOnly);
                    }
                }
            }

            OnStatusUpdate("Album and Metadata Update Complete");
        }

        public static string PathSafeString(string s)
        {
            char replaceValue = '_';

            foreach (var c in Path.GetInvalidFileNameChars())
            {
                s = s.Replace(c, replaceValue);
            }

            foreach (var c in Path.GetInvalidPathChars())
            {
                s = s.Replace(c, replaceValue);
            }

            //for some reaason "&" is not in list of invalid chars
            s = s.Replace("&", "_");

            //make sure a path does not end with a dot
            s = s.Replace("./", "_/");

            if (s.Trim().EndsWith("."))
                s = s.Substring(0, s.LastIndexOf(".")) + "_";

            return s;
        }


        public static void MoveITunesFile(IITFileOrCDTrack track, string newRootPath, bool testOnly)
        {

            //build new path based on track info
            if (!newRootPath.EndsWith("\\"))
                newRootPath = newRootPath + "\\";

            string oldPathAndFileName = track.Location;

            OnStatusUpdate("Old File Path: " + oldPathAndFileName);

            string newPath = string.Format(@"{0}{1}\{2}\",
                newRootPath,
                PathSafeString(track.Artist.Trim()),
                PathSafeString(track.Album.Trim())
                );
            
            string newPathAndFileName = string.Format(@"{0}{1} {2}{3}",
                newPath,
                track.TrackNumber.ToString("00"), //need to ensure it is 2 digits prefixed with 0 if necessary
                PathSafeString(track.Name.Trim()), //need to ensure "unsafe" characters are removed
                Path.GetExtension(track.Location)
                );

            
            //check to make sure old and new paths are not the same

            //raise event to send new path back
            OnStatusUpdate("New File Path: " + newPathAndFileName);

            if(File.Exists(newPathAndFileName))
            {
                OnStatusUpdate("FILE ALREADY EXISTS IN NEW LOCATION - NOT UPDATING!");
                return;
            }

            if (!testOnly)
            {
                
                //copy file
                if (!Directory.Exists(newPath))
                    Directory.CreateDirectory(newPath);

                File.Copy(oldPathAndFileName, newPathAndFileName, true);
                OnStatusUpdate("File Copied");

                //update iTunesFile Location
                track.Location = newPathAndFileName;

                //delete old file
                File.Delete(oldPathAndFileName);
            }
        }

        public static List<IITFileOrCDTrack> ITunesMusicTracks
        {
            get
            {
                if (_itunesTracks == null)
                {
                    _itunesTracks = (from tracks in Common.GetITunesTracks()
                                     where tracks.Genre != "Podcast"
                                     && tracks.Genre != "Audiobook"
                                     && tracks.Genre != "Voice Memo"
                                     && tracks.Location != string.Empty
                                     select tracks).ToList();
                }

                return _itunesTracks;
            }
             
        }

        public static void ReloadITunesMusicTracks()
        {
            if (_itunesTracks != null)
                _itunesTracks.Clear();
            ITunesMusicTracks.Count();
        }

        private static List<IITFileOrCDTrack> _itunesTracks;

        public static IEnumerable<IITFileOrCDTrack> GetITunesTracks()
        {
            int i = 0;
            foreach (var track in new iTunesAppClass().LibraryPlaylist.Tracks)
            {
                if (track is IITFileOrCDTrack)
                {
                    if (((IITFileOrCDTrack)track).Kind == ITTrackKind.ITTrackKindFile)
                    {
                        yield return (IITFileOrCDTrack)track;
                    }
                }
                else
                {
                    Console.WriteLine("ID: {0} not of type IITFileOrCDTrack : {1}", i, track);
                }
                i++;
            }
        }

        public static void DeleteEmptyDirectories(string dir, bool testOnly)
        {
            if (String.IsNullOrEmpty(dir))
                throw new ArgumentException(
                    "Starting directory is a null reference or an empty string",
                    "dir");

            try
            {
                foreach (var d in Directory.EnumerateDirectories(dir))
                {
                    DeleteEmptyDirectories(d, testOnly);
                }

                var entries = Directory.EnumerateFileSystemEntries(dir);

                if (!entries.Any())
                {
                    try
                    {
                        if(!testOnly)
                            Directory.Delete(dir);

                        OnStatusUpdate("Deleted: " + dir);
                    }
                    catch (UnauthorizedAccessException) { }
                    catch (DirectoryNotFoundException) { }
                }
            }
            catch (UnauthorizedAccessException) { }
        }

        public static void DeleteFiles(string dir, string searchPattern, bool testOnly)
        {
            //doing this recursive folder list to avoid issues with some folders that are system controlled and give an unauthorized access exception
            //Directory.Enumerate is much faster than prior means which make this reasonable
            try
            {
                foreach (var d in Directory.EnumerateDirectories(dir))
                {
                    DeleteFiles(d, searchPattern, testOnly);
                }

                foreach (var f in Directory.EnumerateFiles(dir, searchPattern))
                {
                    try
                    {
                        if (!testOnly)
                            File.Delete(f);

                        OnStatusUpdate("Deleted: " + f);
                    }
                    catch (UnauthorizedAccessException) { }
                    catch (DirectoryNotFoundException) { }
                }
            }
            catch (UnauthorizedAccessException) { }
        }

    }
}
