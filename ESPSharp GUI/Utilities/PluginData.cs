using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESPSharp;
using ESPSharp_GUI.DockableForms;

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


		/// <summary>
		/// Gets a list of paths for all checked plugins, then starts a task to load plugin data.
		/// Handles all work that should be done after task loading.
		/// </summary>
		/// <param name="items">ListView items to check against for plugins to load.</param>
		public static async void StartPluginLoading(IEnumerable items)
		{
			// Build paths using the local data directory and the known plugin names.
			var paths = (from ListViewItem item
						 in items
						 where item.Checked
						 select Path.Combine(Settings.DataPath, item.Text)).ToArray();

			// Used to update the listview each time a plugin loads
			var progress = new Progress<string>(update => 
			{
				PluginListWindow.Instance.UpdateList();
			});

			// Inform the user we're starting to load
			Messenger.AddMessage("Starting plugin loading...");

			// Start loading
			var task = Task.Factory.StartNew(() => OpenPlugins(paths, progress));

			// Continuation events after main plugin loading
			await task.ContinueWith(t => { Messenger.AddMessage("Finished loading plugins."); },
							TaskContinuationOptions.OnlyOnRanToCompletion);

			// Todo: Fire off ESP# function to background load/refresh reference data
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="files"></param>
		/// <param name="progress"></param>
		private static void OpenPlugins(string[] files, IProgress<string> progress)
		{
            ElderScrollsPlugin.OnProgressUpdate += (message, level) =>
            {
                progress.Report(message);
            };
			Plugins = new List<ElderScrollsPlugin>();
			ElderScrollsPlugin.Clear();

			ElderScrollsPlugin.pluginLocations.Add(new KeyValuePair<string, bool>(Settings.DataPath, false));

			ElderScrollsPlugin.OnProgressUpdate += delegate(string msg, LogLevel level)
			{
				if (level == LogLevel.Plugin || level == LogLevel.Group)
				Messenger.AddMessage(msg);
			};

			foreach (var file in files)
			{
				if (ElderScrollsPlugin.LoadedPlugins.Any(esp => esp.Name == file))
					Plugins.Add(ElderScrollsPlugin.LoadedPlugins.First(esp => esp.Name == file));
				else
				{
					var plugin = new ElderScrollsPlugin(Path.GetFileName(file));
					try
					{
						plugin.Read(file);
						Plugins.Add(plugin);
						progress.Report("");    // Gotta update the plugin list
					}
					catch (IOException ex)
					{
						Messenger.AddError("Aborting...", ex);
						return;
					}

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
