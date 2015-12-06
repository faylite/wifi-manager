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
		/// <summary>
		/// Calls IOHandler.GetStoredConfigFielNames() and filters out the interface name and file extension,
		/// and returns a String List with the profile names
		/// </summary>
		/// <returns>A String List with stored profile names</returns>
		public List<String> GetStoredProfileList()
		{
			XmlReader xmlReader = new XmlReader();

			List<String> returnBuilder = new List<String>();
			foreach(string s in IOHandler.GetStoredConfigFilesWithPath())
			{
				// Match match = Regex.Match(s, @"(?:^\w+-)(.*)(?:\.xml$)", RegexOptions.IgnoreCase);
				// returnBuilder.Add(match.Groups[1].Value);

				returnBuilder.Add(xmlReader.GetProfileName(s));
			}
			return returnBuilder;
		}

		/// <summary>
		/// Gets the output from GetNetshWlanProfiles() uses regex to get the network profile names, 
		/// and returns a list of the available network profiles on the current machine
		/// </summary>
		/// <returns>A string list with local network profile names</returns>
		public List<String> GetLocalProfileList()
		{
			// Get the netsh wlan profiles
			string netshOutput = GetNetshWlanProfiles();
			List<string> wifiList = new List<string>();

			// Find all the AP names and put them into the wifiList
			MatchCollection matches = Regex.Matches(netshOutput, @"(?::\s)(.*)", RegexOptions.IgnoreCase);
            foreach (Match m in matches)
			{
				if (m.Groups[1].Value.Length > 1)
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
		public string GetNetshWlanProfiles()
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
