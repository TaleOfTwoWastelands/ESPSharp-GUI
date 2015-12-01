using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESPSharp_GUI.DockableForms;
using ESPSharp_GUI.Utilities;
using WeifenLuo.WinFormsUI.Docking;

namespace ESPSharp_GUI
{
	public partial class LoadListWindow : DockContent
	{
		public static LoadListWindow Instance => _instance ?? (_instance = new LoadListWindow());
		private static LoadListWindow _instance;

		public LoadListWindow()
		{
			InitializeComponent();

			ReadPluginFiles();
		}

		/// <summary>
		/// Reads in plugin list files for the current game.
		/// </summary>
		private void ReadPluginFiles()
		{
			using (var reader = new StreamReader(Util.AllPluginsPath))
			{
				while (reader.Peek() >= 0)
				{
					var pluginName = reader.ReadLine();
					if (pluginName == null) continue;
					if (pluginName.EndsWith(".esp") || pluginName.EndsWith(".esm"))
						lvPluginList.Items.Add(pluginName);
				}
			}
			using (var reader = new StreamReader(Util.LoadedPluginsPath))
			{
				while (reader.Peek() >= 0)
				{
					var pluginName = reader.ReadLine();
					if (pluginName == null) continue;
					if (pluginName.EndsWith(".esp") || pluginName.EndsWith(".esm"))
						lvPluginList.FindItemWithText(pluginName).Checked = true;
				}
			}
		}

		private string[] GetFilePaths()
		{
			return (from ListViewItem item in lvPluginList.Items where item.Checked select Path.Combine(Util.DataPath, item.Text)).ToArray();
		}

		/// <summary>
		/// Our job is done, hide this window and start loading plugins.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void buttonOK_Click(object sender, EventArgs e)
		{
			_instance.Hide();

			var paths = GetFilePaths();

			var progress = new Progress<string>(update =>
			{
				MessagesWindow.WriteMessage(update);
				PluginListWindow.Instance.UpdateList();
			});

			MessagesWindow.WriteMessage("Starting plugin loading...");
			await Task.Run(() => PluginData.OpenPlugins(paths, progress));
		}

		private void tsmiCmsSelectAll_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvPluginList.Items)
				item.Checked = true;
		}

		private void tsmiCmsSelectNone_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvPluginList.Items)
				item.Checked = false;
		}

		private void tsmiCmsSelectInvert_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvPluginList.Items)
				item.Checked = !item.Checked;
		}
	}
}

