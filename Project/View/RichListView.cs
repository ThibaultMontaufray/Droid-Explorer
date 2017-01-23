using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Droid_Explorer
{
    public class RichListView : Panel
    {
        #region Attribute
        private List<RichListViewItem> _itemList;
        private System.Windows.Forms.View _display;
        private ImageList _imageList;
        private List<string> _groups;
        private int _panelComponentX;
        private int _panelComponentY;
        private int _panelX = 5;
        private int _panelY = 5;
        private int _tilesColumCapacity;
        private RichListViewItem.Format _size;
        #endregion

        #region Properties
        public List<RichListViewItem> Items
        {
            get { return _itemList; }
            set { _itemList = value; }
        }
        public View Display
        {
            get { return _display; }
            set { _display = value; }
        }
        public ImageList IconList
        {
            get { return _imageList; }
            set { _imageList = value; }
        }
        public List<string> Groups
        {
            get { return _groups; }
            set { _groups = value; }
        }
        public RichListViewItem.Format ComponentSize
        {
            get { return _size; }
            set { _size = value; }
        }
        #endregion

        #region Constructor
        public RichListView()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods public
        public void RefreshComponent()
        {
            if (this.Width / ((int)_size + 5) != _tilesColumCapacity)
            {
                _panelX = 5;
                _panelY = 5;
                this.Controls.Clear();
                if (_display == View.Tile) DrawTiles();
                else if (_display == View.Details) DrawTiles();
            }
        }
        #endregion

        #region Methods private
        private void InitializeComponent()
        {
            this.Dock = DockStyle.Fill;
            this.Resize += new EventHandler(RichListView_Resize);

            _groups = new List<string>();
            _itemList = new List<RichListViewItem>();
            _display = View.Tile;

            RefreshComponent();
        }
        private void DrawTiles()
        {
            foreach (RichListViewItem ril in _itemList)
            {
                DrawTile(ril);
            }
        }
        private void DrawTile(RichListViewItem ril)
        {
            Panel p = new Panel();

            switch (_size)
            {
                case RichListViewItem.Format.MINUS:
                    p.Width = (int)RichListViewItem.Format.MINUS;
                    p.Height = 32;
                    break;
                case RichListViewItem.Format.SMALL:
                    p.Width = (int)RichListViewItem.Format.SMALL;
                    p.Height = 48;
                    break;
                case RichListViewItem.Format.MEDIUM:
                    p.Width = (int)RichListViewItem.Format.MEDIUM;
                    p.Height = 64;
                    break;
                case RichListViewItem.Format.LARGE:
                    p.Width = (int)RichListViewItem.Format.LARGE;
                    p.Height = 70;
                    break;
            }

            _tilesColumCapacity = this.Width / (p.Width + 5);

            p.Name = ril.Text;
            p.Top = _panelY;
            p.Left = _panelX;
            p.BackColor = Color.White;

            CalculatePanelCoord(p);

            PictureBox pb = new PictureBox();
            pb.Width = 50;
            pb.Height = 50;
            pb.Image = this.IconList.Images[ril.ImageIndex > 0 ? ril.ImageIndex : 0];
            pb.Top = 0;
            pb.Left = 0;
            p.Controls.Add(pb);

            Label lb_text = new Label();
            lb_text.Name = "text";
            lb_text.Text = ril.Text;
            lb_text.ForeColor = Color.Black;
            lb_text.Height = 20;
            lb_text.TextAlign = ContentAlignment.BottomLeft;
            if (ril.Details.Count > 0)
            {
                lb_text.Top = 0;
                lb_text.Left = 50;
            }
            else
            {
                lb_text.Top = 14;
                lb_text.Left = 50;
            }
            p.Controls.Add(lb_text);

            _panelComponentX = 50;
            _panelComponentY = 26;

            for (int i = 0; i < ril.Details.Count; i++)
            {
                switch (ril.Details[i].DetFamily)
                {
                    case RichListViewItem.Family.Label:
                        DrawComponentLabel(p, ril.Details[i].DetValue);
                        break;
                    case RichListViewItem.Family.ProgressBar:
                        DrawComponentProgressBar(p, ril.Details[i].DetValue);
                        break;
                }
            }

            this.Controls.Add(p);
        }
        private void DrawComponentLabel(Panel p, string val)
        {
            Label lb_desc = new Label();
            lb_desc.Name = "desc_" + val;
            lb_desc.Text = val;
            lb_desc.Top = _panelComponentY;
            lb_desc.Left = _panelComponentX;
            lb_desc.BackColor = Color.Transparent;
            lb_desc.Height = 20;
            lb_desc.AutoSize = true;
            lb_desc.ForeColor = Color.Gray;
            p.Controls.Add(lb_desc);

            _panelComponentX += lb_desc.Width + 4;
        }
        private void DrawComponentProgressBar(Panel p, string val)
        {
            int percent = 0;
            int.TryParse(val, out percent);

            RichProgressBar pba = new RichProgressBar();
            pba.Name = "desc_" + val;
            pba.Value = percent;
            pba.Maximum = 100;
            pba.Top = _panelComponentY;
            pba.Left = _panelComponentX;
            pba.Width = p.Width - 55;
            pba.Height = 12;
            pba.Style = ProgressBarStyle.Blocks;
            pba.ForeColor = percent > 90 ? Color.Red : Color.DeepSkyBlue;
            p.Controls.Add(pba);

            _panelComponentY += pba.Height + 4;
        }
        private void CalculatePanelCoord(Panel p)
        {
            if (_panelX + 5 + (2 * p.Width) > this.Width)
            {
                _panelX = 5;
                _panelY += 5 + p.Height;
            }
            else
            {
                _panelX += 5 + p.Width;
            }
        }
        #endregion

        #region Event
        private void RichListView_Resize(object sender, EventArgs e)
        {
            RefreshComponent();
        }
        #endregion
    }
}