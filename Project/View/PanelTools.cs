using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Security.AccessControl;
using System.Security.Principal;

namespace Explorer
{
    public class PanelTools : Panel
    {
        #region Attribute
        private ToolControler _toolControler;
        private TreeView _treeView;
        private SplitContainer _sp;
        private GUI _gui;
        private TreeNode _rootNode;
        private ListView _listView;
        private RichListView _listViewDisk;
        //private ListView _listViewDisk;
        private ImageList _imageList;
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public PanelTools()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void InitializeComponent()
        {
            _toolControler = new ToolControler();

            this.Dock = DockStyle.Fill;
            _gui = new GUI();
            LoadTreeView();
            BuildSplitContainer();

            // Initialize the ListView, ImageList and Form.
            _imageList = new ImageList();
            _imageList.ImageSize = new Size(32, 32);
            _imageList.ColorDepth = ColorDepth.Depth32Bit;

            BuildListViewDisk();
        }
        private void BuildSplitContainer()
        {
            _sp = new SplitContainer();
            _sp.Panel1.Controls.Add(_treeView);
            _sp.Orientation = Orientation.Vertical;
            _sp.Dock = DockStyle.Fill;
            this.Controls.Add(_sp);
        }
        private void BuildListViewDisk()
        {
            _listView = new ListView();
            _listView.Dock = DockStyle.Fill;
            _listView.View = View.Tile;
            _listView.LargeImageList = _imageList;
            _listView.SmallImageList = _imageList;
            _listView.StateImageList = _imageList;

            int countFixed = 0;
            int countRemovable = 0;
            int countNetwork = 0;

            _listViewDisk = new RichListView();
            _listViewDisk.Dock = DockStyle.Fill;
            _listViewDisk.IconList = _gui.imageListView32;
            _listViewDisk.Display = View.Tile;
            _listViewDisk.ComponentSize = RichListViewItem.Format.LARGE;
            _sp.Panel2.Controls.Add(this._listViewDisk);

            ListViewGroup lvg_fixed = new ListViewGroup("Hard disk drive");
            ListViewGroup lvg_removable_storage = new ListViewGroup("Devices with removable storage");
            ListViewGroup lvg_network = new ListViewGroup("Network Location");
            _listViewDisk.Groups.Add(lvg_fixed.Header);
            _listViewDisk.Groups.Add(lvg_removable_storage.Header);
            _listViewDisk.Groups.Add(lvg_network.Header);

            RichListViewItem richLV;
            foreach (var item in _toolControler.ListDrivers)
            {
                richLV = new RichListViewItem(item.text);
                richLV.Size = RichListViewItem.Format.LARGE;
                if (item.type == DriveType.Fixed)
                {
                    Detail d;

                    d = new Detail();
                    d.DetFamily = RichListViewItem.Family.ProgressBar;
                    d.DetValue = (((item.totalSpace - item.freeSpace) * 100) / item.totalSpace).ToString();
                    richLV.Details.Add(d);

                    if (item.totalSpace > 0)
                    {
                        d = new Detail();
                        d.DetFamily = RichListViewItem.Family.Label;
                        d.DetValue = (item.freeSpace / 1000000000).ToString() + " GB free of " + (item.totalSpace / 1000000000).ToString() + " GB";
                        richLV.Details.Add(d);
                    }

                    richLV.ImageIndex = _listViewDisk.IconList.Images.IndexOfKey("disk");
                    richLV.Group = lvg_fixed.Header;
                    countFixed++;
                }
                else if (item.type == DriveType.Network)
                {
                    Detail d;

                    d = new Detail();
                    d.DetFamily = RichListViewItem.Family.ProgressBar;
                    d.DetValue = (((item.totalSpace - item.freeSpace) * 100) / item.totalSpace).ToString();
                    richLV.Details.Add(d);

                    if (item.totalSpace > 0)
                    {
                        d = new Detail();
                        d.DetFamily = RichListViewItem.Family.Label;
                        d.DetValue = (item.freeSpace / 1000000000).ToString() + " GB free of " + (item.totalSpace / 1000000000).ToString() + " GB";
                        richLV.Details.Add(d);
                    }

                    richLV.ImageIndex = _listViewDisk.IconList.Images.IndexOfKey("network");
                    richLV.Group = lvg_network.Header;
                    countNetwork++;
                }
                else
                {
                    richLV.ImageIndex = _listViewDisk.IconList.Images.IndexOfKey("cd");
                    richLV.Group = lvg_removable_storage.Header;
                    countRemovable++;
                }
                _listViewDisk.Items.Add(richLV);
                //_listViewDisk.ItemActivate += new EventHandler(_listViewDisk_ItemActivate);
            }
            // TODO : integrate each item list view ...
            lvg_fixed.Header = lvg_fixed.Header + " (" + countFixed + ")";
            lvg_network.Header = lvg_network.Header + " (" + countNetwork + ")";
            lvg_removable_storage.Header = lvg_removable_storage.Header + " (" + countRemovable + ")";
            LoadDiskPreview();
            _listViewDisk.RefreshComponent();
        }
        private void BuildListViewDiskOLD()
        {
            //_listView = new ListView();
            //_listView.Dock = DockStyle.Fill;
            //_listView.SmallImageList = _imageList;
            //_listView.LargeImageList = _imageList;
            //_listView.StateImageList = _imageList;
            //_listView.View = View.Tile;
            //_sp.Panel2.Controls.Add(this._listView);

            //int countFixed = 0;
            //int countRemovable = 0;
            //int countNetwork = 0;

            //_listViewDisk = new ListView();
            //_listViewDisk.Dock = DockStyle.Fill;
            //_listViewDisk.View = View.Tile;
            //_listViewDisk.LargeImageList = _gui.imageListView32;
            //_listViewDisk.SmallImageList = _gui.imageListView32;
            //_listViewDisk.StateImageList = _gui.imageListView32;

            //ListViewGroup lvg_fixed = new ListViewGroup("Hard disk drive");
            //ListViewGroup lvg_removable_storage = new ListViewGroup("Devices with removable storage");
            //ListViewGroup lvg_network = new ListViewGroup("Network Location");
            //_listViewDisk.Groups.Add(lvg_fixed);
            //_listViewDisk.Groups.Add(lvg_removable_storage);
            //_listViewDisk.Groups.Add(lvg_network);

            //ListViewItem lvi;
            //foreach (var item in _toolControler.ListDrivers)
            //{
            //    lvi = new ListViewItem(item.text);
            //    if (item.type == DriveType.Fixed)
            //    {
            //        lvi.ImageIndex = _listViewDisk.LargeImageList.Images.IndexOfKey("disk");
            //        lvi.Group = lvg_fixed;
            //        countFixed++;
            //    }
            //    else if (item.type == DriveType.Network)
            //    {
            //        lvi.ImageIndex = _listViewDisk.LargeImageList.Images.IndexOfKey("network");
            //        lvi.Group = lvg_network;
            //        countNetwork++;
            //    }
            //    else
            //    {
            //        lvi.ImageIndex = _listViewDisk.LargeImageList.Images.IndexOfKey("cd");
            //        lvi.Group = lvg_removable_storage;
            //        countRemovable++;
            //    }
            //    _listViewDisk.Items.Add(lvi);
            //    _listViewDisk.ItemActivate += new EventHandler(_listViewDisk_ItemActivate);
            //}

            //lvg_fixed.Header = lvg_fixed.Header + " (" + countFixed + ")";
            //lvg_network.Header = lvg_network.Header + " (" + countNetwork + ")";
            //lvg_removable_storage.Header = lvg_removable_storage.Header + " (" + countRemovable + ")";
            //LoadDiskPreview();
        }
        private void LoadTreeView()
        {
            _treeView = new TreeView();
            _treeView.Dock = DockStyle.Fill;
            _treeView.ImageList = _gui.imageListTreeview;
            _treeView.AfterSelect += new TreeViewEventHandler(_treeView_AfterSelect);
            _treeView.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            _rootNode = new TreeNode("Computer", _treeView.ImageList.Images.IndexOfKey("computer"), _treeView.ImageList.Images.IndexOfKey("computer"));

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (MountPoint mp in _toolControler.ListDrivers)
            {
                TreeNode node;
                if (mp.type == DriveType.Fixed)
                {
                    node = new TreeNode(mp.text, _treeView.ImageList.Images.IndexOfKey("disk"), _treeView.ImageList.Images.IndexOfKey("disk"));
                    LoadSubNodes(ref node, mp.letter + ":\\");
                }
                else if (mp.type == DriveType.Network)
                {
                    node = new TreeNode(mp.text, _treeView.ImageList.Images.IndexOfKey("network"), _treeView.ImageList.Images.IndexOfKey("network"));
                    LoadSubNodes(ref node, mp.letter + ":\\");
                }
                else if (mp.type == DriveType.CDRom)
                {
                    node = new TreeNode(mp.text, _treeView.ImageList.Images.IndexOfKey("cd"), _treeView.ImageList.Images.IndexOfKey("cd"));
                }
                else
                {
                    node = new TreeNode(mp.text, _treeView.ImageList.Images.IndexOfKey("folder"), _treeView.ImageList.Images.IndexOfKey("folder"));
                }
                _rootNode.Nodes.Add(node);

                if (mp.type == DriveType.Fixed || mp.type == DriveType.Network || mp.type == DriveType.Removable)
                {
                    LoadSubNodes(ref node, mp.letter + ":\\");
                }
            }
            _rootNode.Expand();
            _treeView.Nodes.Add(_rootNode);
        }
        private void LoadSubNodes(ref TreeNode node, string path)
        {
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    DirectoryInfo di = new DirectoryInfo(path);
                    foreach (var fi in di.GetDirectories("*", SearchOption.TopDirectoryOnly))
                    {
                        if (!fi.Attributes.ToString().Contains(FileAttributes.Hidden.ToString()))
                        {
                            TreeNode tn = new TreeNode(fi.Name);
                            bool flag = true;
                            foreach (TreeNode n in node.Nodes)
                            {
                                if (n.Text == tn.Text)
                                {
                                    flag = false;
                                    break;
                                }
                            }
                            if (flag) node.Nodes.Add(tn);
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                node.ImageIndex = _treeView.ImageList.Images.IndexOfKey("folder_lock");
                node.SelectedImageIndex = _treeView.ImageList.Images.IndexOfKey("folder_lock");
                MessageBox.Show(path + " is not accessible.\n\n Access is denied.", "Location is not available", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void LoadPreview()
        {
            if (!_sp.Panel2.Controls.Contains(this._listView))
            {
                _sp.Panel2.Controls.Remove(this._listViewDisk);
                _sp.Panel2.Controls.Add(this._listView);
            }

            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(_toolControler.CurrentPath);

            ListViewItem item;
            _listView.Items.Clear();
            _listView.BeginUpdate();

            try
            {
                foreach (System.IO.FileInfo file in dir.GetFiles())
                {
                    Icon iconForFile = SystemIcons.WinLogo;
                    item = new ListViewItem(file.Name, 1);
                    ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, "test");
                    item.SubItems.Add(subItem);

                    iconForFile = Icon.ExtractAssociatedIcon(file.FullName);

                    if (!_imageList.Images.ContainsKey(file.Extension))
                    {
                        iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName);
                        _imageList.Images.Add(file.Extension, iconForFile);
                    }
                    item.ImageKey = file.Extension;
                    _listView.Items.Add(item);
                }
            }
            catch (Exception)
            {
            }
            _listView.EndUpdate();
        }
        private void LoadDiskPreview()
        {
            if (!_sp.Panel2.Controls.Contains(this._listViewDisk))
            {
                _sp.Panel2.Controls.Remove(this._listView);
                _sp.Panel2.Controls.Add(this._listViewDisk);
                this._listViewDisk.RefreshComponent();
                _sp.Panel2.Invalidate();
            }
        }
        private void RefreshExplorer()
        {
            if (_treeView.SelectedNode != null)
            {
                if (_treeView.SelectedNode == _rootNode)
                {
                    LoadDiskPreview();
                }
                else
                {
                    StringBuilder path = new StringBuilder();
                    TreeNode nodeExplorer = _treeView.SelectedNode;

                    do
                    {
                        if (nodeExplorer.Text.Contains(':')) path.Insert(0, nodeExplorer.Text.Split('(')[1].Split(')')[0] + "\\");
                        else path.Insert(0, nodeExplorer.Text + "\\");
                        nodeExplorer = nodeExplorer.Parent;
                    }
                    while (nodeExplorer != _rootNode);
                    _toolControler.CurrentPath = path.ToString();

                    TreeNode tn = _treeView.SelectedNode;
                    LoadSubNodes(ref tn, _toolControler.CurrentPath);
                    _treeView.SelectedNode.Expand();
                    LoadPreview();
                }
            }
        }
        #endregion

        #region Event
        private void _listViewDisk_ItemActivate(object sender, EventArgs e)
        {
            //if (_listViewDisk.FocusedItem != null)
            //{
            //    foreach (TreeNode item in _rootNode.Nodes)
            //    {
            //        if (_listViewDisk.FocusedItem.Text.Equals(item.Text))
            //        {
            //            _treeView.SelectedNode = item;
            //            RefreshExplorer();
            //            break;
            //        }
            //    }
            //}
        }
        private void _treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            RefreshExplorer();
        }
        #endregion
    }
}