using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ESPSharp_GUI.Utilities
{
	public class Util
	{
		public static string CurrentPath = Application.StartupPath;

		public static string UserScriptsPath = Path.Combine(CurrentPath, "ESPSharp User Scripts");

		public static RegistryKey BethesdaRegKey
        {
            get
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
        }

		public static string GamePath
        {
            get
            {
                using (BethesdaRegKey)
                using (var subKey = BethesdaRegKey.CreateSubKey("falloutnv"))
                {
                    Debug.Assert(subKey != null, "subKey != null");
                    return subKey.GetValue("Installed Path", "").ToString();
                }
            }
        }
	}
}
