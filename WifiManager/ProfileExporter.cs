using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WifiManager
{
	/// <summary>
	/// This class exports profiles on the current machine to the ./data/conf directory
	/// </summary>
	class ProfileExporter
	{
		// Export the profiles provided in the list
		public void exportProfiles(List<string> profileNames)
		{
			foreach (string s in profileNames)
			{
				exportProfile(s);
			}
		}

		// Exports the provided profile
		public void exportProfile(string profileName)
		{
			string exportCommand = (
				"/c netsh wlan export profile " +
				profileName + " " +
				IOHandler.profileFolder +
				" key=clear"
			);

			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = "cmd.exe";
			proc.StartInfo.Arguments = exportCommand;
			proc.StartInfo.UseShellExecute = false;
			proc.StartInfo.CreateNoWindow = true;
			proc.StartInfo.RedirectStandardOutput = true;
			proc.Start();
			string s = proc.StandardOutput.ReadToEnd();
			proc.WaitForExit();
		}
	}
}
