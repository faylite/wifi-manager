using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WifiManager
{
	class XmlReader
	{
		/// <summary>
		/// Returns the profile name in the xml configuration file
		/// </summary>
		/// <param name="xmlPath">Path to the xml file for the profile to read</param>
		/// <returns>Profile Name</returns>
		public string GetProfileName(string xmlPath)
		{
			// Load the xml file
			var doc = XDocument.Load(xmlPath);

			// Find the value in the name tags (Lookup namespaces and xml for reason for this solution... it's 4am)
			Match match = Regex.Match(doc.ToString(), @"<name>(.*)</name>", RegexOptions.IgnoreCase);

			// Return match
			return match.Groups[1].Value;
		}
	}
}
