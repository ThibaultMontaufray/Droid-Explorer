/*

* Created by SharpDevelop.

* User: tmontauf040213

* Date: 26/12/2013

* Time: 17:04

*

 * To change this template use Tools | Options | Coding | Edit Standard Headers.

*/



namespace Droid_Explorer
{

    partial class RichExplorer
    {

        /// <summary>

        /// Designer variable used to keep track of non-visual components.

        /// </summary>

        private System.ComponentModel.IContainer components = null;



        /// <summary>

        /// Disposes resources used by the form.

        /// </summary>

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        protected override void Dispose(bool disposing)
        {

            if (disposing)
            {

                if (components != null)
                {

                    components.Dispose();

                }

            }

            base.Dispose(disposing);

        }



        /// <summary>

        /// This method is required for Windows Forms designer support.

        /// Do not change the method contents inside the source code editor. The Forms designer might

        /// not be able to load this method if it was changed manually.

        /// </summary>

        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonTools = new System.Windows.Forms.Button();
            this.panelTools1 = new Droid_Explorer.PanelTools();
            this.SuspendLayout();
            // 
            // buttonTools
            // 
            this.buttonTools.Location = new System.Drawing.Point(0, 0);
            this.buttonTools.Name = "buttonTools";
            this.buttonTools.Size = new System.Drawing.Size(75, 23);
            this.buttonTools.TabIndex = 0;
            // 
            // panelTools1
            // 
            this.panelTools1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTools1.Location = new System.Drawing.Point(0, 0);
            this.panelTools1.Name = "panelTools1";
            this.panelTools1.Size = new System.Drawing.Size(621, 530);
            this.panelTools1.TabIndex = 0;
            // 
            // RichExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 530);
            this.Controls.Add(this.panelTools1);
            this.MinimumSize = new System.Drawing.Size(370, 500);
            this.Name = "RichExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private PanelTools panelTools1;
        private System.Windows.Forms.Button buttonTools;
    }

}

