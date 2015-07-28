using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WifiConnector
{
    class WifiImporter
    {
        string cmdListStoredWifi = "/c netsh wlan show profiles";
		//string regexWifiName = "(?::\\s:?)\\w+\\n";
		string regexWifiName = ":\\s\\w+";

        public WifiImporter()
        {
        }

        public void storeWifi()
        {

		}
		public string getListOfWifiNetworks()
		{
			// Get the netsh wlan profiles
			string netshOutput = getNetshWlanProfiles();
			List<string> wifiList = new List<string>();

			// Find all the AP names and put them into the wifiList
			MatchCollection matches = Regex.Matches(netshOutput, regexWifiName);
			foreach (Match m in matches)
			{
				foreach (Capture c in m.Captures)
				{
					string capture = c.Value.Replace(": ", "");
					wifiList.Add(capture);
				}
			}
			// Remove duplicate AP names
			wifiList = wifiList.Distinct().ToList();
			// Return string
			string rs = "";
			foreach (string s in wifiList)
			{
				rs += s + "\r\n";
			}

			return rs;
		}
		public string getNetshWlanProfiles()
		{
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = "cmd.exe";
			proc.StartInfo.Arguments = cmdListStoredWifi;
			proc.StartInfo.UseShellExecute = false;
			proc.StartInfo.CreateNoWindow = true;
			proc.StartInfo.RedirectStandardOutput = true;
			proc.Start();
			string s = proc.StandardOutput.ReadToEnd();
			proc.WaitForExit();
			return s;
		}
	}
}
