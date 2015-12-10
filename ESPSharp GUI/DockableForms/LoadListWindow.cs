using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESPSharp_GUI.DockableForms;
using ESPSharp_GUI.Interfaces;
using ESPSharp_GUI.Utilities;
using WeifenLuo.WinFormsUI.Docking;

namespace ESPSharp_GUI
{
	public partial class LoadListWindow : DockContent, IDockableForm
	{
		public static LoadListWindow Instance => _instance ?? (_instance = new LoadListWindow());
		private static LoadListWindow _instance;

		public DockState DefaultState { get; } = DockState.Document;

		public LoadListWindow()
		{
			InitializeComponent();

			ReadPluginFiles();
		}

		/// <summary>
		/// Reads in plugin list files for the current game and loads them into the listview.
		/// Automatically checks plugins that are listed as enabled.
		/// </summary>
		private void ReadPluginFiles()
		{
            foreach (var plugin in Settings.AllPlugins)
                lvPluginList.Items.Add(Path.GetFileName(plugin));
            foreach (var plugin in Settings.ActivePlugins)
                lvPluginList.FindItemWithText(plugin).Checked = true;
		}

		
		/// <summary>
		/// Event for OK button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonOK_Click(object sender, EventArgs e)
		{
			Hide();
			PluginData.StartPluginLoading(lvPluginList.Items);
		}


		#region Context Menu Events
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
		#endregion Context Menu Events
	}
}

