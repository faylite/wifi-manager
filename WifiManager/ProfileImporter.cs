﻿using System;
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
				// Use xml reader to find profile name in xml file instead of using filename that contains interface name
				XmlReader xmlReader = new XmlReader();
				if(profileName == xmlReader.GetProfileName(s))
				{
					ImportProfileCmd(s);
				}
			}
		}
		private void ImportProfileCmd(string filePath)
		{
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = "cmd.exe";
			proc.StartInfo.Arguments = "/c netsh wlan add profile \"" + filePath + "\"";
			proc.StartInfo.UseShellExecute = false;
			proc.StartInfo.CreateNoWindow = true;
			proc.StartInfo.RedirectStandardOutput = true;
			proc.Start();
			string s = proc.StandardOutput.ReadToEnd();
			proc.WaitForExit();
		}
	}
}
