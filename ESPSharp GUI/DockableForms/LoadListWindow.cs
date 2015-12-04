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
            foreach (var plugin in Settings.AllPlugins)
                lvPluginList.Items.Add(Path.GetFileName(plugin));
            foreach (var plugin in Settings.ActivePlugins)
                lvPluginList.FindItemWithText(plugin).Checked = true;
		}

		/// <summary>
		/// Our job is done, hide this window and start loading plugins.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void buttonOK_Click(object sender, EventArgs e)
		{
			_instance.Hide();

            // Build paths using the local data directory and the known plugin names.
            var paths = (from ListViewItem item 
                         in lvPluginList.Items
                         where item.Checked
                         select Path.Combine(Settings.DataPath, item.Text)).ToArray();

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

