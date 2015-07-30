using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WifiManager
{
    public partial class MainWindow : Form
    {
		private ProfileImporter importer;
		private ProfileExporter exporter;
		private ProfileInfo info;

        public MainWindow()
        {
            InitializeComponent();

			importer = new ProfileImporter();
			exporter = new ProfileExporter();
			info = new ProfileInfo();
			
			// Create data folder if not already created
			IOHandler.createFolders();

			// Update the list of available profiles on start, good UX people ;)
			listStoredProfiles(null, null);
			listLocalProfiles(null, null);
        }

		private void listStoredProfiles(object sender, EventArgs e)
		{
			lbAvailableProfileList.Items.Clear();
			foreach(string s in info.getStoredProfileList())
			{
				lbAvailableProfileList.Items.Add(s);
			}
		}

		private void listLocalProfiles(object sender, EventArgs e)
		{
			lbLocalProfileList.Items.Clear();
			foreach(string s in info.getLocalProfileList())
			{
				lbLocalProfileList.Items.Add(s);
			}
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnExportAll_Click(object sender, EventArgs e)
		{
			exporter.exportProfiles(info.getLocalProfileList());
			listStoredProfiles(null, null);
		}

		private void btExportSelected_Click(object sender, EventArgs e)
		{
			foreach (String s in lbLocalProfileList.CheckedItems)
			{
				exporter.exportProfile(s);
			}
			listStoredProfiles(null, null);
		}

		private void btImportAll_Click(object sender, EventArgs e)
		{
			foreach (String s in info.getStoredProfileList())
			{
				importer.importProfile(s);
			}
		}

		private void btImportSelected_Click(object sender, EventArgs e)
		{
			foreach (string s in lbAvailableProfileList.CheckedItems)
			{
				importer.importProfile(s);
			}
		}

		private void deleteDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			IOHandler.clearAllStoredProfiles();
		}
	}
}
