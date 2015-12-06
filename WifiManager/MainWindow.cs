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

		private static string programName = "Wifi Manager";

		private static int vMajor = 1;
		private static int vMinor = 2;
		private static int vHotfix = 0;
#if DEBUG
		private static string release = " Debug";
#else
		private static string release = "";
#endif
		private static string version = vMajor + "." + vMinor + "."+ vHotfix + release;

		private string author = "By: Benjamin (Faylite)";

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
			IOHandler.CreateFolders();

			// Update the list of available profiles on start, good UX people ;)
			ListStoredProfiles(null, null);
			ListLocalProfiles(null, null);
        }

		private void ListStoredProfiles(object sender, EventArgs e)
		{
			lbAvailableProfileList.Items.Clear();
			foreach(string s in info.GetStoredProfileList())
			{
				try
				{
					lbAvailableProfileList.Items.Add(s);
				}
				catch (ArgumentNullException)
				{
					// Break if there were no arguments to add
					break;
				}
			}
		}

		private void ListLocalProfiles(object sender, EventArgs e)
		{
			lbLocalProfileList.Items.Clear();
			foreach(string s in info.GetLocalProfileList())
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
			exporter.ExportProfiles(info.GetLocalProfileList());
			ListStoredProfiles(null, null);
		}

		private void btExportSelected_Click(object sender, EventArgs e)
		{
			foreach (String s in lbLocalProfileList.CheckedItems)
			{
				exporter.ExportProfile(s);
			}
			ListStoredProfiles(null, null);
		}

		private void btImportAll_Click(object sender, EventArgs e)
		{
			foreach (String s in info.GetStoredProfileList())
			{
				importer.ImportProfile(s);
			}
		}

		private void btImportSelected_Click(object sender, EventArgs e)
		{
			foreach (string s in lbAvailableProfileList.CheckedItems)
			{
				importer.ImportProfile(s);
			}
		}

		private void deleteDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			IOHandler.ClearAllStoredProfiles();
			ListStoredProfiles(null, null);
		}

		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListStoredProfiles(null, null);
			ListLocalProfiles(null, null);
		}

		private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MessageBox.Show((programName + " " + version + "\r\n\r\n" + author), "About");
		}
	}
}
