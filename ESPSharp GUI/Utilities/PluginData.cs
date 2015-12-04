using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ESPSharp;

namespace ESPSharp_GUI.Utilities
{
	public enum EspDataType
	{
		Plugin,
		Group,
		RecordView,
		Record,
		None
	}

	static class PluginData
	{
		public static List<ElderScrollsPlugin> Plugins;


		public static void OpenPlugins(string[] files, IProgress<string> progress)
		{
			Plugins = new List<ElderScrollsPlugin>();
			ElderScrollsPlugin.Clear();

			ElderScrollsPlugin.pluginLocations.Add(new KeyValuePair<string, bool>(Util.DataPath, false));
			ElderScrollsPlugin.pluginLocations.Add(new KeyValuePair<string, bool>(Util.MOPath, true));

			foreach (var file in files)
			{
				if (ElderScrollsPlugin.LoadedPlugins.Any(esp => esp.Name == file))
					Plugins.Add(ElderScrollsPlugin.LoadedPlugins.First(esp => esp.Name == file));
				else
				{
					var plugin = new ElderScrollsPlugin(Path.GetFileName(file));
					plugin.Read(file);
					
					Plugins.Add(plugin);
					progress.Report("Loaded plugin data for: " + Path.GetFileName(file));
				}
			}
		}


		public static EspDataType ObjectType(object obj)
		{
			if (obj is ElderScrollsPlugin)
				return EspDataType.Plugin;
			if (obj is Group)
				return EspDataType.Group;
			if (obj is RecordView)
				return EspDataType.RecordView;
			if (obj is Record)
				return EspDataType.Record;
			return EspDataType.None;
		}

		public static ElderScrollsPlugin GetRecordViewMasterFile(RecordView recordView)
		{
			return ElderScrollsPlugin.LoadedPlugins.FirstOrDefault(p => p.RecordViews.Contains(recordView));
		}
	}
}
