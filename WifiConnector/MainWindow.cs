using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WifiConnector
{
    public partial class MainWindow : Form
    {
		private ProfileImporter importer;
		private ProfileExporter exporter;
		private IOHandler io;

        public MainWindow()
        {
            InitializeComponent();

			importer = new ProfileImporter();
			tbWiFiList.Text = importer.getListOfWifiNetworks();
			exporter = new ProfileExporter();

			io = new IOHandler();
			io.createFolders();
        }

		private void listWifi(object sender, EventArgs e)
		{
			tbWiFiList.Text = importer.getListOfWifiNetworks();
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
			exporter.exportProfiles(importer.getListOfProfiles());
		}
	}
}
