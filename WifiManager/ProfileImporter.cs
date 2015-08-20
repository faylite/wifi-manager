using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WifiManager
{
	/// <summary>
	/// Contains functionality to import the network profiles stored in ./data/conf,
	/// if available.
	/// </summary>
    class ProfileImporter
    {
		public void ImportProfile(string profileName)
		{
			foreach(string s in IOHandler.GetStoredConfigFilesWithPath())
			{
				Match match = Regex.Match(s, @"(?:\w+-)(\w+)(?:.xml$)", RegexOptions.IgnoreCase);
				if(match.Groups[1].Success)
				{
					ImportProfileCmd(s);
				}
			}
		}
		private void ImportProfileCmd(string filePath)
		{
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = "cmd.exe";
			proc.StartInfo.Arguments = "/c netsh wlan add profile " + filePath;
			proc.StartInfo.UseShellExecute = false;
			proc.StartInfo.CreateNoWindow = true;
			proc.StartInfo.RedirectStandardOutput = true;
			proc.Start();
			string s = proc.StandardOutput.ReadToEnd();
			proc.WaitForExit();
		}
	}
}
