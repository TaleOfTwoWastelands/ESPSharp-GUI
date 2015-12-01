using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ESPSharp_GUI.Utilities
{
	public class Util
	{
		public static string CurrentPath = Application.ExecutablePath;

		//public static string AllPluginsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Fallout4", "loadorder.txt");


		//public static string LoadedPluginsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
		//	"Fallout4", "plugins.txt");

			// Because ModOrganizer keeps them in different locations
		public static string AllPluginsPath =
			@"G:\Games\Steam\steamapps\common\fallout new vegas\ModOrganizer\profiles\New Vegas\loadorder.txt";

		public static string LoadedPluginsPath =
			@"G:\Games\Steam\steamapps\common\fallout new vegas\ModOrganizer\profiles\New Vegas\plugins.txt";

		public static string DataPath = @"G:\Games\Steam\steamapps\common\fallout new vegas\Data";

		public static string MOPath = @"G:\Games\Steam\steamapps\common\fallout new vegas\ModOrganizer\mods";

		public RegistryKey GetBethKey()
		{
			using (var bethKey =
				Registry.LocalMachine.OpenSubKey(
				//determine software reg path (depends on architecture)
				Environment.Is64BitOperatingSystem ? "Software\\Wow6432Node" : "Software", RegistryKeyPermissionCheck.ReadWriteSubTree))
			//create or retrieve BethSoft path
			{
				Debug.Assert(bethKey != null, "bethKey != null");
				return bethKey.CreateSubKey("Bethesda Softworks", RegistryKeyPermissionCheck.ReadWriteSubTree);
			}
		}

		public string GetPathFromKey(string keyName)
		{
			using (var bethKey = GetBethKey())
			using (var subKey = bethKey.CreateSubKey(keyName))
			{
				Debug.Assert(subKey != null, "subKey != null");
				return subKey.GetValue("Installed Path", "").ToString();
			}
		}


	}
}
