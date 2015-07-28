using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WifiConnector
{
	class IOHandler
	{
		public static string dataFolder = "data";
		public static string networkConfDir = dataFolder + "\\conf";

		string exePath = AppDomain.CurrentDomain.BaseDirectory;

		public void createFolders()
		{
			System.IO.Directory.CreateDirectory(exePath + dataFolder);
			System.IO.Directory.CreateDirectory(exePath + networkConfDir);
		}

	}
}
