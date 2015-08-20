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

		public static string dataFolder = exePath + "data"; // Data folder location
		public static string profileFolder = dataFolder + "\\profiles"; // Stored profiles location

		public static void CreateFolders()
		{
			System.IO.Directory.CreateDirectory(dataFolder);
			System.IO.Directory.CreateDirectory(profileFolder);
		}

		/// <summary>
		/// Calls GetStoredConfigFilesWithPath() and filters out the full file path
		/// and returns the file names only
		/// </summary>
		/// <returns>A list of filenames for the network config files</returns>
		public static List<String> GetStoredConfigFileNames()
		{
			List<String> returnBuilder = new List<string>();
			foreach (string s in GetStoredConfigFilesWithPath())
			{
				returnBuilder.Add(Path.GetFileName(s));
			}
			return returnBuilder;
		}

		/// <summary>
		/// Searches the conf directory and returns a list of full paths with the files
		/// </summary>
		/// <returns>A list of full paths to the profiles in the conf directory</returns>
		public static List<String> GetStoredConfigFilesWithPath()
		{
			return System.IO.Directory.GetFiles((profileFolder), "*.xml").ToList();
		}

		/// <summary>
		/// Clears all the profiles stored by the program
		/// </summary>
		public static void ClearAllStoredProfiles()
		{
			foreach (string s in GetStoredConfigFilesWithPath())
			{
				DeleteStoredProfile(s);
			}
		}
		public static void DeleteStoredProfile(string filePath)
		{
			try
			{
				File.Delete(filePath);
			}
			catch (IOException ioex)
			{
				Console.WriteLine(ioex);
			}
		}
	}
}
