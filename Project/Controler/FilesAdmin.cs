using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Droid_Explorer
{
    public static class FilesAdmin
    {
        #region Attribute
        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        private static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken, out string pszPath);
        private static readonly Guid Downloads = new Guid("374DE290-123F-4565-9164-39C4925E467B");

        private static List<KeyValuePair<string, string>> _specialFolders;
        #endregion

        #region Properties
        public static List<KeyValuePair<string, string>> SpecialFolders
        {
            get { return _specialFolders; }
        }
        #endregion

        #region Constructor
        static FilesAdmin()
        {
            string downloads;
            _specialFolders = new List<KeyValuePair<string, string>>();
            
            _specialFolders.Add(new KeyValuePair<string, string>("Bureau", Environment.GetFolderPath(Environment.SpecialFolder.Desktop)));
            _specialFolders.Add(new KeyValuePair<string, string>("Documents", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)));

            SHGetKnownFolderPath(Downloads, 0, IntPtr.Zero, out downloads);
            _specialFolders.Add(new KeyValuePair<string, string>("Download", downloads));
            _specialFolders.Add(new KeyValuePair<string, string>("Images", Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)));
            _specialFolders.Add(new KeyValuePair<string, string>("Musique", Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)));
            _specialFolders.Add(new KeyValuePair<string, string>("Videos", Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)));
        }
        #endregion

        #region Methods public
        public static string GetFile(string path, string fileName)
        {
            path = CleanPath(path);
            return path + fileName;
        }
        public static void LaunchDefaultProgram(string path, string fileName)
        {
            try
            {
                string file = GetFile(path, fileName);
                ProcessStartInfo pi = new ProcessStartInfo(file);
                pi.Arguments = Path.GetFileName(file);
                pi.UseShellExecute = true;
                pi.WorkingDirectory = Path.GetDirectoryName(file);
                pi.FileName = file;
                pi.Verb = "OPEN";
                Process.Start(pi);
            }
            catch (Exception exp)
            {
                Tools4Libraries.Log.Write("[ ERR 0000 ] Error while executing the program : " + exp.Message);
            }
        }
        public static string CleanPath(string path)
        {
            string finalPath = string.Empty;
            path = path.Replace("Computer\\", string.Empty);
            List<string> tab = Regex.Split(path, @"\([A-Z]:\)").ToList();

            if (tab.Count > 0)
            {
                foreach (var specialFolder in _specialFolders)
                {
                    if (tab[0].StartsWith(specialFolder.Key))
                    {
                        finalPath = path.Replace(specialFolder.Key, specialFolder.Value);
                        return finalPath.Replace("Computer\\", string.Empty) + "\\";
                    }
                }
                if (path.Contains('(') && path.Contains(')'))
                { 
                    finalPath = path.Split('(')[1].Split(')')[0];
                    finalPath += tab[1];
                }
            }
            return path + "\\";
        }
        #endregion

        #region Methods private
        #endregion
    }
}
