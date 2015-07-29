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
		private IOHandler io;

        public MainWindow()
        {
            InitializeComponent();

			importer = new ProfileImporter();
			exporter = new ProfileExporter();
			info = new ProfileInfo();
			io = new IOHandler();
			// Create data folder if not already created
			io.createFolders();

			// Update the list of available profiles on start, good UX people ;)
			listWifi(null, null);
        }

		private void listWifi(object sender, EventArgs e)
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
		}
	}
}
