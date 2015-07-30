using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WifiManager
{
	/// <summary>
	/// This class is used to get info about the available network profiles,
	/// on the current machine and the profiles stored in the ./data/conf directory
	/// </summary>
	class ProfileInfo
	{
		public List<String> getStoredProfileList()
		{
			// TODO: Remove interface name and file extension
			List<String> returnBuilder = new List<String>();
			foreach(string s in IOHandler.getStoredConfigFileNames())
			{

			}

			return IOHandler.getStoredConfigFileNames();
		}

		/// <summary>
		/// Gets the output from getNetshWlanProfiles() uses regex to get the network profile names, 
		/// and returns a list of the available network profiles on the current machine
		/// </summary>
		/// <returns>A string list with network profile names</returns>
		public List<String> getLocalProfileList()
		{
			// Get the netsh wlan profiles
			string netshOutput = getNetshWlanProfiles();
			List<string> wifiList = new List<string>();

			// Find all the AP names and put them into the wifiList
			// TODO: Check if the regex works with multiple profiles, I only had one profile on my machine
			MatchCollection matches = Regex.Matches(netshOutput, @"(?::\s)(\w+)", RegexOptions.IgnoreCase);
            foreach (Match m in matches)
			{
				wifiList.Add(m.Groups[1].Value);
			}
			// Return a list with no duplicate profiles
			// In case of multiple Wifi cards
			return wifiList.Distinct().ToList();
		}

		/// <summary>
		/// Runs a netsh command to get all the network profiles on the current machine
		/// </summary>
		/// <returns>Raw output from the cmd command</returns>
		public string getNetshWlanProfiles()
		{
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = "cmd.exe";
			proc.StartInfo.Arguments = "/c netsh wlan show profiles";
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
