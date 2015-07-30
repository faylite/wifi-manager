using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WifiManager
{
	class IOHandler
	{
		public static string exePath = AppDomain.CurrentDomain.BaseDirectory;

		public static string dataFolder = exePath + "data";
		public static string profileFolder = dataFolder + "\\conf";

		public static void createFolders()
		{
			System.IO.Directory.CreateDirectory(dataFolder);
			System.IO.Directory.CreateDirectory(profileFolder);
		}

		/// <summary>
		/// Searches trough the network conf directory and returns a list
		/// of file names for the available configurations
		/// </summary>
		/// <returns>A list of filenames for the network config files</returns>
		public static List<String> getStoredConfigFileNames()
		{
			List<String> returnBuilder = new List<string>();
			foreach (string s in getStoredConfigFilesWithPath())
			{
				returnBuilder.Add(Path.GetFileName(s));
			}
			return returnBuilder;
		}

		public static List<String> getStoredConfigFilesWithPath()
		{
			List<String> returnBuilder = new List<String>();
			string[] configFiles = System.IO.Directory.GetFiles((profileFolder), "*.xml");

			for (int i = 0; i < configFiles.Length; i++)
			{
				returnBuilder.Add(configFiles[i]);
			}
			return returnBuilder;
		}
	}
}
