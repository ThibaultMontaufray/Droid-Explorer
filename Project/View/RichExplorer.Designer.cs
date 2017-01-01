/*

* Created by SharpDevelop.

* User: tmontauf040213

* Date: 26/12/2013

* Time: 17:04

*

 * To change this template use Tools | Options | Coding | Edit Standard Headers.

*/



namespace Explorer
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
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonTools = new System.Windows.Forms.Button();
            this.buttonMonitoring = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSQLScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.extraLargeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mapNetworkDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectNetworkDireveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSyncCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTools1 = new Explorer.PanelTools();
            this.schedulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tobiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.Location = new System.Drawing.Point(511, 171);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(138, 95);
            this.buttonCalendar.TabIndex = 0;
            this.buttonCalendar.Text = "CALENDARS";
            this.buttonCalendar.UseVisualStyleBackColor = true;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // buttonTools
            // 
            this.buttonTools.Location = new System.Drawing.Point(655, 171);
            this.buttonTools.Name = "buttonTools";
            this.buttonTools.Size = new System.Drawing.Size(138, 95);
            this.buttonTools.TabIndex = 1;
            this.buttonTools.Text = "TOOLS";
            this.buttonTools.UseVisualStyleBackColor = true;
            this.buttonTools.Click += new System.EventHandler(this.buttonTools_Click);
            // 
            // buttonMonitoring
            // 
            this.buttonMonitoring.Location = new System.Drawing.Point(799, 171);
            this.buttonMonitoring.Name = "buttonMonitoring";
            this.buttonMonitoring.Size = new System.Drawing.Size(138, 95);
            this.buttonMonitoring.TabIndex = 2;
            this.buttonMonitoring.Text = "MONITORING";
            this.buttonMonitoring.UseVisualStyleBackColor = true;
            this.buttonMonitoring.Click += new System.EventHandler(this.buttonMonitoring_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.editToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.toolStripSeparator4,
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.menuToolStripMenuItem.Text = "File";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Enabled = false;
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(114, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.invertSelectionToolStripMenuItem,
            this.renameFilesToolStripMenuItem,
            this.createSQLScriptToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Enabled = false;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectAllToolStripMenuItem.Text = "Select all";
            // 
            // invertSelectionToolStripMenuItem
            // 
            this.invertSelectionToolStripMenuItem.Enabled = false;
            this.invertSelectionToolStripMenuItem.Name = "invertSelectionToolStripMenuItem";
            this.invertSelectionToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.invertSelectionToolStripMenuItem.Text = "Invert selection";
            // 
            // renameFilesToolStripMenuItem
            // 
            this.renameFilesToolStripMenuItem.Name = "renameFilesToolStripMenuItem";
            this.renameFilesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.renameFilesToolStripMenuItem.Text = "Rename files";
            this.renameFilesToolStripMenuItem.Click += new System.EventHandler(this.renameFilesToolStripMenuItem_Click);
            // 
            // createSQLScriptToolStripMenuItem
            // 
            this.createSQLScriptToolStripMenuItem.Name = "createSQLScriptToolStripMenuItem";
            this.createSQLScriptToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.createSQLScriptToolStripMenuItem.Text = "Create SQL script";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarToolStripMenuItem,
            this.toolStripSeparator1,
            this.extraLargeIconsToolStripMenuItem,
            this.largeIconToolStripMenuItem,
            this.mediumIconToolStripMenuItem,
            this.smallIconToolStripMenuItem,
            this.listToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.tileToolStripMenuItem,
            this.contentToolStripMenuItem,
            this.toolStripSeparator2,
            this.refreshToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.windowsToolStripMenuItem.Text = "View";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Enabled = false;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.statusBarToolStripMenuItem.Text = "Status bar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // extraLargeIconsToolStripMenuItem
            // 
            this.extraLargeIconsToolStripMenuItem.Enabled = false;
            this.extraLargeIconsToolStripMenuItem.Name = "extraLargeIconsToolStripMenuItem";
            this.extraLargeIconsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.extraLargeIconsToolStripMenuItem.Text = "Extra large icons";
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Enabled = false;
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.largeIconToolStripMenuItem.Text = "Large icons";
            // 
            // mediumIconToolStripMenuItem
            // 
            this.mediumIconToolStripMenuItem.Enabled = false;
            this.mediumIconToolStripMenuItem.Name = "mediumIconToolStripMenuItem";
            this.mediumIconToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.mediumIconToolStripMenuItem.Text = "Medium icons";
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Enabled = false;
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.smallIconToolStripMenuItem.Text = "Small icon";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Enabled = false;
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.listToolStripMenuItem.Text = "List";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Enabled = false;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Enabled = false;
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.tileToolStripMenuItem.Text = "Tiles";
            // 
            // contentToolStripMenuItem
            // 
            this.contentToolStripMenuItem.Enabled = false;
            this.contentToolStripMenuItem.Name = "contentToolStripMenuItem";
            this.contentToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.contentToolStripMenuItem.Text = "Content";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarToolStripMenuItem,
            this.monitorToolStripMenuItem,
            this.schedulerToolStripMenuItem,
            this.tobiToolStripMenuItem,
            this.toolStripSeparator3,
            this.mapNetworkDriveToolStripMenuItem,
            this.disconnectNetworkDireveToolStripMenuItem,
            this.openSyncCenterToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // calendarToolStripMenuItem
            // 
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.calendarToolStripMenuItem.Text = "Calendar";
            this.calendarToolStripMenuItem.Click += new System.EventHandler(this.calendarToolStripMenuItem_Click);
            // 
            // monitorToolStripMenuItem
            // 
            this.monitorToolStripMenuItem.Name = "monitorToolStripMenuItem";
            this.monitorToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.monitorToolStripMenuItem.Text = "Monitor";
            this.monitorToolStripMenuItem.Click += new System.EventHandler(this.monitorToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(217, 6);
            // 
            // mapNetworkDriveToolStripMenuItem
            // 
            this.mapNetworkDriveToolStripMenuItem.Enabled = false;
            this.mapNetworkDriveToolStripMenuItem.Name = "mapNetworkDriveToolStripMenuItem";
            this.mapNetworkDriveToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.mapNetworkDriveToolStripMenuItem.Text = "Map network drive ...";
            // 
            // disconnectNetworkDireveToolStripMenuItem
            // 
            this.disconnectNetworkDireveToolStripMenuItem.Enabled = false;
            this.disconnectNetworkDireveToolStripMenuItem.Name = "disconnectNetworkDireveToolStripMenuItem";
            this.disconnectNetworkDireveToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.disconnectNetworkDireveToolStripMenuItem.Text = "Disconnect network drive ...";
            // 
            // openSyncCenterToolStripMenuItem
            // 
            this.openSyncCenterToolStripMenuItem.Enabled = false;
            this.openSyncCenterToolStripMenuItem.Name = "openSyncCenterToolStripMenuItem";
            this.openSyncCenterToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.openSyncCenterToolStripMenuItem.Text = "Open Sync Center ...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutExplorerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutExplorerToolStripMenuItem
            // 
            this.aboutExplorerToolStripMenuItem.Enabled = false;
            this.aboutExplorerToolStripMenuItem.Name = "aboutExplorerToolStripMenuItem";
            this.aboutExplorerToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutExplorerToolStripMenuItem.Text = "About Explorer ++";
            // 
            // panelTools1
            // 
            this.panelTools1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTools1.Location = new System.Drawing.Point(0, 24);
            this.panelTools1.Name = "panelTools1";
            this.panelTools1.Size = new System.Drawing.Size(621, 506);
            this.panelTools1.TabIndex = 0;
            // 
            // schedulerToolStripMenuItem
            // 
            this.schedulerToolStripMenuItem.Name = "schedulerToolStripMenuItem";
            this.schedulerToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.schedulerToolStripMenuItem.Text = "Scheduler";
            this.schedulerToolStripMenuItem.Click += new System.EventHandler(this.schedulerToolStripMenuItem_Click);
            // 
            // tobiToolStripMenuItem
            // 
            this.tobiToolStripMenuItem.Name = "tobiToolStripMenuItem";
            this.tobiToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.tobiToolStripMenuItem.Text = "Tobi";
            this.tobiToolStripMenuItem.Click += tobiToolStripMenuItem_Click;
            // 
            // RichExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 530);
            this.Controls.Add(this.panelTools1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RichExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private PanelTools panelTools1;
        private System.Windows.Forms.Button buttonMonitoring;
        private System.Windows.Forms.Button buttonTools;
        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mapNetworkDriveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectNetworkDireveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSyncCenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraLargeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem renameFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSQLScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tobiToolStripMenuItem;
    }

}

