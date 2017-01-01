using System.Windows.Forms;

namespace Explorer
{
    public class RichContextMenu : ContextMenuStrip
    {
        #region Attribute
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public RichContextMenu()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods private
        private void InitializeComponent()
        {
            BuildMenuItems();
        }
        private void BuildMenuItems()
        {
            ToolStripMenuItem tsi;
            ToolStripSeparator tss;

            tsi = new ToolStripMenuItem("Open");
            tsi.Enabled = true;
            //tsi.ShortcutKeyDisplayString = "O";
            //tsi.ShortcutKeys = Keys.O;
            this.Items.Add(tsi);

            tss = new ToolStripSeparator();
            this.Items.Add(tss);

            tsi = new ToolStripMenuItem("Copy");
            tsi.Enabled = false;
            this.Items.Add(tsi);

            tsi = new ToolStripMenuItem("Cut");
            tsi.Enabled = false;
            this.Items.Add(tsi);

            tss = new ToolStripSeparator();
            this.Items.Add(tss);

            tsi = new ToolStripMenuItem("Delete");
            tsi.Enabled = false;
            this.Items.Add(tsi);

            tsi = new ToolStripMenuItem("Rename");
            tsi.Enabled = false;
            this.Items.Add(tsi);

            tss = new ToolStripSeparator();
            this.Items.Add(tss);

            tsi = new ToolStripMenuItem("Properties");
            tsi.Enabled = false;
            this.Items.Add(tsi);
        }
        #endregion
    }
}
