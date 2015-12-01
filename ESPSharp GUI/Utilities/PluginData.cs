using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ESPSharp;

namespace ESPSharp_GUI.Utilities
{
	static class PluginData
	{
		public static List<ElderScrollsPlugin> Plugins = new List<ElderScrollsPlugin>();
		private static List<RecordView> listRecords = new List<RecordView>();

		public static void OpenPlugins(string[] files, IProgress<string> progress)
		{
			ElderScrollsPlugin.pluginLocations.Add(new KeyValuePair<string, bool>(Util.DataPath, false));
			ElderScrollsPlugin.pluginLocations.Add(new KeyValuePair<string, bool>(Util.MOPath, true));

			foreach (var file in files)
			{
				if (ElderScrollsPlugin.LoadedPlugins.Any(esp => esp.Name == file))
					Plugins.Add(ElderScrollsPlugin.LoadedPlugins.First(esp => esp.Name == file));
				else
				{
					var plugin = new ElderScrollsPlugin(Path.GetFileName(file));
					plugin.ReadBinary(file);

					//MergeDuplicateTopGroups(plugin, progress);
					Plugins.Add(plugin);
					progress.Report("Loaded plugin data for: " + Path.GetFileName(file));
				}
			}
		}


		private static void MergeDuplicateTopGroups(ElderScrollsPlugin plugin, IProgress<string> progress)
		{
			List<Group> groups = new List<Group>();

			for (int index = 0; index < plugin.TopGroups.Count; index++)
			{
				var topGroup = plugin.TopGroups[index];
				

				var dupGroups = plugin.TopGroups.FindAll(g => g.ToString().Equals(topGroup.ToString()));

				foreach (var group in dupGroups)
				{
					foreach (var allRecordView in group.AllRecordViews)
						if (!topGroup.AllRecordViews.Contains(allRecordView))
							topGroup.AllRecordViews.Add(allRecordView);

					foreach (var allSubgroup in group.AllSubgroups)
						if (!topGroup.AllSubgroups.Contains(allSubgroup))
							topGroup.AllSubgroups.Add(allSubgroup);

					foreach (var childRecordView in group.ChildRecordViews)
						if (!topGroup.ChildRecordViews.Contains(childRecordView))
							topGroup.ChildRecordViews.Add(childRecordView);

					foreach (var child in group.Children)
						if (!topGroup.Children.Contains(child))
							topGroup.Children.Add(child);
				}
			}
		}
	}
}
