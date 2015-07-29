namespace WifiManager
{
    partial class MainWindow
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
			this.btnUpdateList = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.btnExportAll = new System.Windows.Forms.Button();
			this.lbLocalProfileList = new System.Windows.Forms.CheckedListBox();
			this.tcMainTabs = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.btImportSelectedProfiles = new System.Windows.Forms.Button();
			this.lbAvailableProfileList = new System.Windows.Forms.CheckedListBox();
			this.btImportAllProfiles = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.tcMainTabs.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnUpdateList
			// 
			this.btnUpdateList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdateList.AutoSize = true;
			this.btnUpdateList.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnUpdateList.Location = new System.Drawing.Point(448, 292);
			this.btnUpdateList.Name = "btnUpdateList";
			this.btnUpdateList.Size = new System.Drawing.Size(200, 68);
			this.btnUpdateList.TabIndex = 1;
			this.btnUpdateList.Text = "Update Configuration List";
			this.btnUpdateList.UseVisualStyleBackColor = true;
			this.btnUpdateList.Click += new System.EventHandler(this.listWifi);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(686, 28);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem1});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
			this.aboutToolStripMenuItem1.Text = "About";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(293, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "WiFi Configurations available on this machine";
			// 
			// btnExportAll
			// 
			this.btnExportAll.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnExportAll.Location = new System.Drawing.Point(227, 292);
			this.btnExportAll.Name = "btnExportAll";
			this.btnExportAll.Size = new System.Drawing.Size(200, 68);
			this.btnExportAll.TabIndex = 6;
			this.btnExportAll.Text = "Export All Configurations";
			this.btnExportAll.UseVisualStyleBackColor = true;
			this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
			// 
			// lbLocalProfileList
			// 
			this.lbLocalProfileList.FormattingEnabled = true;
			this.lbLocalProfileList.Location = new System.Drawing.Point(3, 23);
			this.lbLocalProfileList.Name = "lbLocalProfileList";
			this.lbLocalProfileList.Size = new System.Drawing.Size(645, 259);
			this.lbLocalProfileList.TabIndex = 7;
			// 
			// tcMainTabs
			// 
			this.tcMainTabs.Controls.Add(this.tabPage1);
			this.tcMainTabs.Controls.Add(this.tabPage2);
			this.tcMainTabs.Location = new System.Drawing.Point(12, 40);
			this.tcMainTabs.Name = "tcMainTabs";
			this.tcMainTabs.SelectedIndex = 0;
			this.tcMainTabs.Size = new System.Drawing.Size(662, 395);
			this.tcMainTabs.TabIndex = 8;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.btImportSelectedProfiles);
			this.tabPage1.Controls.Add(this.lbAvailableProfileList);
			this.tabPage1.Controls.Add(this.btImportAllProfiles);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(654, 366);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Import";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Controls.Add(this.lbLocalProfileList);
			this.tabPage2.Controls.Add(this.btnExportAll);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.btnUpdateList);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(654, 366);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Export";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Default;
			this.button1.Location = new System.Drawing.Point(6, 292);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(200, 68);
			this.button1.TabIndex = 8;
			this.button1.Text = "Export Selected Configurations";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btImportSelectedProfiles
			// 
			this.btImportSelectedProfiles.Cursor = System.Windows.Forms.Cursors.Default;
			this.btImportSelectedProfiles.Location = new System.Drawing.Point(6, 292);
			this.btImportSelectedProfiles.Name = "btImportSelectedProfiles";
			this.btImportSelectedProfiles.Size = new System.Drawing.Size(200, 68);
			this.btImportSelectedProfiles.TabIndex = 13;
			this.btImportSelectedProfiles.Text = "Import Selected Configurations";
			this.btImportSelectedProfiles.UseVisualStyleBackColor = true;
			// 
			// lbAvailableProfileList
			// 
			this.lbAvailableProfileList.FormattingEnabled = true;
			this.lbAvailableProfileList.Location = new System.Drawing.Point(6, 25);
			this.lbAvailableProfileList.Name = "lbAvailableProfileList";
			this.lbAvailableProfileList.Size = new System.Drawing.Size(642, 259);
			this.lbAvailableProfileList.TabIndex = 12;
			// 
			// btImportAllProfiles
			// 
			this.btImportAllProfiles.Cursor = System.Windows.Forms.Cursors.Default;
			this.btImportAllProfiles.Location = new System.Drawing.Point(227, 292);
			this.btImportAllProfiles.Name = "btImportAllProfiles";
			this.btImportAllProfiles.Size = new System.Drawing.Size(200, 68);
			this.btImportAllProfiles.TabIndex = 11;
			this.btImportAllProfiles.Text = "Import All Configurations";
			this.btImportAllProfiles.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(254, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "WiFi Configurations available for import";
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.AutoSize = true;
			this.button2.Cursor = System.Windows.Forms.Cursors.Default;
			this.button2.Location = new System.Drawing.Point(448, 292);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(200, 68);
			this.button2.TabIndex = 14;
			this.button2.Text = "Update Configuration List";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 447);
			this.Controls.Add(this.tcMainTabs);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WiFi Manager";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tcMainTabs.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		
		private System.Windows.Forms.Button btnUpdateList;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExportAll;
		private System.Windows.Forms.CheckedListBox lbLocalProfileList;
		private System.Windows.Forms.TabControl tcMainTabs;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btImportSelectedProfiles;
		private System.Windows.Forms.CheckedListBox lbAvailableProfileList;
		private System.Windows.Forms.Button btImportAllProfiles;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
	}
}

