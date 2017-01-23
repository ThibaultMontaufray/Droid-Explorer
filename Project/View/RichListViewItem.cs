using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Droid_Explorer
{
    public struct Detail
    {
        public RichListViewItem.Family DetFamily;
        public string DetValue;
    }

    public class RichListViewItem
    {
        #region enum
        public enum Format
        {
            MINUS = 16,
            SMALL = 32,
            MEDIUM = 48,
            LARGE = 220
        }
        public enum Family
        {
            Label,
            ProgressBar
        }
        #endregion

        #region Attribute
        private string _text;
        private List<Detail> _details;
        private Format _format = Format.MEDIUM;
        private int _imageIndex;
        private string _group;
        #endregion

        #region Properties
        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }
        public int ImageIndex
        {
            get { return _imageIndex; }
            set { _imageIndex = value; }
        }
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
        public List<Detail> Details
        {
            get { return _details; }
            set { _details = value; }
        }
        public Format Size
        {
            get { return _format; }
            set { _format = value; }
        }
        #endregion

        #region Constructor
        public RichListViewItem()
        {
            _details = new List<Detail>();
        }
        public RichListViewItem(string text)
        {
            _details = new List<Detail>();
            this.Text = text;
        }
        #endregion
    }
}