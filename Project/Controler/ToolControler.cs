using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Droid_Explorer
{
    public struct MountPoint
    {
        public string label;
        public DriveType type;
        public long totalSpace;
        public long freeSpace;
        public string letter;
        public string text;
    }
    public class ToolControler
    {
        #region Attribute
        private string _currentPath;
        private string[] _currentFileList;
        private string[] _currentFolderList;
        private List<MountPoint> _listMountPoint;
        private MountPoint _currentMountPoint;
        #endregion

        #region Properties
        public List<MountPoint> ListDrivers
        {
            get { return _listMountPoint; }
        }
        public string CurrentPath
        {
            get { return _currentPath; }
            set
            {
                _currentPath = value;
                UpdateCurrentMountPoint();
                UpdateFileList();
                UpdateFolderList();
            }
        }
        public string[] CurrentFolderList
        {
            get { return _currentFolderList; }
            set { _currentFolderList = value; }
        }
        public string[] CurrentFileList
        {
            get { return _currentFileList; }
            set { _currentFileList = value; }
        }
        #endregion

        #region Constructor
        public ToolControler()
        {
            UpdateMountPoints();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void UpdateMountPoints()
        {
            _currentMountPoint = new MountPoint();
            _listMountPoint = new List<MountPoint>();
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                MountPoint mp = new MountPoint();
                mp.type = drive.DriveType;
                mp.letter = drive.Name.Split(':')[0];

                if (drive.DriveType == DriveType.Fixed)
                {
                    mp.text = drive.VolumeLabel + " (" + drive.Name.Split('\\')[0] + ")";
                    mp.freeSpace = drive.AvailableFreeSpace;
                    mp.totalSpace = drive.TotalSize;
                }
                else if (drive.DriveType == DriveType.Network)
                {
                    mp.text = drive.VolumeLabel + " (" + drive.Name.Split('\\')[0] + ")";
                    mp.freeSpace = drive.AvailableFreeSpace;
                    mp.totalSpace = drive.TotalSize;
                }
                else if (drive.DriveType == DriveType.CDRom)
                {
                    mp.text = drive.DriveType + " (" + drive.Name.Split('\\')[0] + ")";
                }
                else
                {
                    mp.text = drive.DriveType + " (" + drive.Name.Split('\\')[0] + ")";
                }
                _listMountPoint.Add(mp);
            }
        }
        private void UpdateFileList()
        {
            if (_currentMountPoint.type == DriveType.Fixed || _currentMountPoint.type == DriveType.Network || _currentMountPoint.type == DriveType.Removable)
            {
                _currentFileList = Directory.GetFiles(_currentPath);
            }
        }
        private void UpdateFolderList()
        {
            if (_currentMountPoint.type == DriveType.Fixed || _currentMountPoint.type == DriveType.Network || _currentMountPoint.type == DriveType.Removable)
            {
                _currentFolderList = Directory.GetDirectories(_currentPath);
            }
        }
        private void UpdateCurrentMountPoint()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (_currentPath.Contains(drive.Name))
                {
                    break;
                }
            }
        }
        #endregion

        #region Event
        #endregion
    }
}