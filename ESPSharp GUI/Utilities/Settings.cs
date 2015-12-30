using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ESPSharp_GUI.Utilities
{
    public static class Settings
    {
        public static List<string> AllPlugins
        {
            get
            {
				return Directory.EnumerateFiles(DataPath)
                    .Where(f => Path.GetExtension(f).ToLower() == ".esm" || Path.GetExtension(f).ToLower() == ".esp")
                    .OrderBy(file => new FileInfo(file).LastWriteTime)
                    .ToList();
            }
        }

        public static List<string> ActivePlugins
        {
            get
            {
                using (FileStream stream = new FileStream(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FalloutNV", "plugins.txt"), FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(stream))
                {
                    List<string> activePlugins = new List<string>();
                    string line;
                    do
                    {
                        line = reader.ReadLine();
                        if (line == null)
                            break;
                        activePlugins.Add(line);
                    }
                    while (line != "" && !reader.EndOfStream);
                    return activePlugins;
                }
            }
        }

        public static string DataPath
        {
            get
            {
                return Path.Combine(Util.GamePath, "Data");
            }
        }
    }
}
