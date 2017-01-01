namespace Explorer
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
            this.imageListView32 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageListTreeview
            // 
            this.imageListTreeview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTreeview.ImageStream")));
            this.imageListTreeview.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTreeview.Images.SetKeyName(0, "folder");
            this.imageListTreeview.Images.SetKeyName(1, "cd");
            this.imageListTreeview.Images.SetKeyName(2, "disk");
            this.imageListTreeview.Images.SetKeyName(3, "computer");
            this.imageListTreeview.Images.SetKeyName(4, "network");
            // 
            // imageListView32
            // 
            this.imageListView32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListView32.ImageStream")));
            this.imageListView32.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListView32.Images.SetKeyName(0, "cd");
            this.imageListView32.Images.SetKeyName(1, "network");
            this.imageListView32.Images.SetKeyName(2, "folder");
            this.imageListView32.Images.SetKeyName(3, "disk");
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
        public System.Windows.Forms.ImageList imageListView32;

    }
}