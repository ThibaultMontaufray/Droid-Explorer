namespace Droid_Explorer
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.imageListTreeview = new System.Windows.Forms.ImageList(this.components);
            this.imageList32 = new System.Windows.Forms.ImageList(this.components);
            this.imageList48 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageListTreeview
            // 
            this.imageListTreeview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTreeview.ImageStream")));
            this.imageListTreeview.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTreeview.Images.SetKeyName(0, "folder");
            this.imageListTreeview.Images.SetKeyName(1, "bureau");
            this.imageListTreeview.Images.SetKeyName(2, "documents");
            this.imageListTreeview.Images.SetKeyName(3, "download");
            this.imageListTreeview.Images.SetKeyName(4, "musique");
            this.imageListTreeview.Images.SetKeyName(5, "computer");
            this.imageListTreeview.Images.SetKeyName(6, "videos");
            this.imageListTreeview.Images.SetKeyName(7, "network");
            this.imageListTreeview.Images.SetKeyName(8, "disk");
            this.imageListTreeview.Images.SetKeyName(9, "diskOs");
            this.imageListTreeview.Images.SetKeyName(10, "cd");
            this.imageListTreeview.Images.SetKeyName(11, "images");
            // 
            // imageList32
            // 
            this.imageList32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList32.ImageStream")));
            this.imageList32.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList32.Images.SetKeyName(0, "cd");
            this.imageList32.Images.SetKeyName(1, "network");
            this.imageList32.Images.SetKeyName(2, "folder");
            this.imageList32.Images.SetKeyName(3, "disk");
            // 
            // imageList48
            // 
            this.imageList48.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList48.ImageStream")));
            this.imageList48.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList48.Images.SetKeyName(0, "disk");
            this.imageList48.Images.SetKeyName(1, "diskOs");
            this.imageList48.Images.SetKeyName(2, "dvd");
            this.imageList48.Images.SetKeyName(3, "folderDesktop");
            this.imageList48.Images.SetKeyName(4, "folderDocument");
            this.imageList48.Images.SetKeyName(5, "folderDownload");
            this.imageList48.Images.SetKeyName(6, "folderImage");
            this.imageList48.Images.SetKeyName(7, "folderMusic");
            this.imageList48.Images.SetKeyName(8, "folderVideo");
            this.imageList48.Images.SetKeyName(9, "network");
            this.imageList48.Images.SetKeyName(10, "sd");
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "GUI";
            this.Text = "GUI";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ImageList imageListTreeview;
        public System.Windows.Forms.ImageList imageList32;
        public System.Windows.Forms.ImageList imageList48;
    }
}