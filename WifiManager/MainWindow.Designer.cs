﻿namespace WifiManager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.btnExportAll = new System.Windows.Forms.Button();
			this.lbLocalProfileList = new System.Windows.Forms.CheckedListBox();
			this.tcMainTabs = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btImportSelected = new System.Windows.Forms.Button();
			this.lbAvailableProfileList = new System.Windows.Forms.CheckedListBox();
			this.btImportAll = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btExportSelected = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.tcMainTabs.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(467, 28);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.deleteDataToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
			// 
			// deleteDataToolStripMenuItem
			// 
			this.deleteDataToolStripMenuItem.Name = "deleteDataToolStripMenuItem";
			this.deleteDataToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
			this.deleteDataToolStripMenuItem.Text = "Delete All Stored Configurations";
			this.deleteDataToolStripMenuItem.Click += new System.EventHandler(this.deleteDataToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(125, 26);
			this.aboutToolStripMenuItem1.Text = "About";
			this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(354, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Choose WiFi configurations to export from this machine";
			// 
			// btnExportAll
			// 
			this.btnExportAll.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnExportAll.Location = new System.Drawing.Point(227, 288);
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
			this.lbLocalProfileList.Location = new System.Drawing.Point(6, 23);
			this.lbLocalProfileList.Name = "lbLocalProfileList";
			this.lbLocalProfileList.Size = new System.Drawing.Size(421, 259);
			this.lbLocalProfileList.TabIndex = 7;
			// 
			// tcMainTabs
			// 
			this.tcMainTabs.Controls.Add(this.tabPage1);
			this.tcMainTabs.Controls.Add(this.tabPage2);
			this.tcMainTabs.Location = new System.Drawing.Point(12, 31);
			this.tcMainTabs.Name = "tcMainTabs";
			this.tcMainTabs.SelectedIndex = 0;
			this.tcMainTabs.Size = new System.Drawing.Size(443, 391);
			this.tcMainTabs.TabIndex = 8;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btImportSelected);
			this.tabPage1.Controls.Add(this.lbAvailableProfileList);
			this.tabPage1.Controls.Add(this.btImportAll);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(435, 362);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Import";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btImportSelected
			// 
			this.btImportSelected.Cursor = System.Windows.Forms.Cursors.Default;
			this.btImportSelected.Location = new System.Drawing.Point(6, 288);
			this.btImportSelected.Name = "btImportSelected";
			this.btImportSelected.Size = new System.Drawing.Size(200, 68);
			this.btImportSelected.TabIndex = 13;
			this.btImportSelected.Text = "Import Selected Configurations";
			this.btImportSelected.UseVisualStyleBackColor = true;
			this.btImportSelected.Click += new System.EventHandler(this.btImportSelected_Click);
			// 
			// lbAvailableProfileList
			// 
			this.lbAvailableProfileList.FormattingEnabled = true;
			this.lbAvailableProfileList.Location = new System.Drawing.Point(6, 23);
			this.lbAvailableProfileList.Name = "lbAvailableProfileList";
			this.lbAvailableProfileList.Size = new System.Drawing.Size(421, 259);
			this.lbAvailableProfileList.TabIndex = 12;
			// 
			// btImportAll
			// 
			this.btImportAll.Cursor = System.Windows.Forms.Cursors.Default;
			this.btImportAll.Location = new System.Drawing.Point(227, 288);
			this.btImportAll.Name = "btImportAll";
			this.btImportAll.Size = new System.Drawing.Size(200, 68);
			this.btImportAll.TabIndex = 11;
			this.btImportAll.Text = "Import All Configurations";
			this.btImportAll.UseVisualStyleBackColor = true;
			this.btImportAll.Click += new System.EventHandler(this.btImportAll_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(338, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "Choose WiFi configurations to import to this machine";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btExportSelected);
			this.tabPage2.Controls.Add(this.lbLocalProfileList);
			this.tabPage2.Controls.Add(this.btnExportAll);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(435, 362);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Export";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btExportSelected
			// 
			this.btExportSelected.Cursor = System.Windows.Forms.Cursors.Default;
			this.btExportSelected.Location = new System.Drawing.Point(6, 288);
			this.btExportSelected.Name = "btExportSelected";
			this.btExportSelected.Size = new System.Drawing.Size(200, 68);
			this.btExportSelected.TabIndex = 8;
			this.btExportSelected.Text = "Export Selected Configurations";
			this.btExportSelected.UseVisualStyleBackColor = true;
			this.btExportSelected.Click += new System.EventHandler(this.btExportSelected_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 435);
			this.Controls.Add(this.tcMainTabs);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainWindow";
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
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExportAll;
		private System.Windows.Forms.CheckedListBox lbLocalProfileList;
		private System.Windows.Forms.TabControl tcMainTabs;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btExportSelected;
		private System.Windows.Forms.Button btImportSelected;
		private System.Windows.Forms.CheckedListBox lbAvailableProfileList;
		private System.Windows.Forms.Button btImportAll;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripMenuItem deleteDataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
	}
}

