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
		private WifiImporter importer;

        public MainWindow()
        {
            InitializeComponent();

			importer = new WifiImporter();
			tbWiFiList.Text = importer.getListOfWifiNetworks();
        }

		private void listWifi(object sender, EventArgs e)
		{
			toolStripStatus.Text = "Getting list of available local wifi configurations...";
			tbWiFiList.Text = importer.getListOfWifiNetworks();
			toolStripStatus.Text = "Done.";
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripStatus.Text = "Exiting....";
			Application.Exit();
		}
	}
}
