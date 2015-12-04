using System;
using System.Windows.Forms;
using BrightIdeasSoftware;
using ESPSharp;
using ESPSharp_GUI.Extensions;

namespace ESPSharp_GUI.DockableForms
{
	public partial class PluginListWindow : PluginList
	{
		public static PluginListWindow Instance => _instance ?? (_instance = new PluginListWindow());
		private static PluginListWindow _instance;

		public PluginListWindow()
		{
			InitializeComponent();

			TlvControl = tlvPluginList;

			SetupTree();
		}

		public void UpdateList()
		{
			tlvPluginList.Roots = ElderScrollsPlugin.LoadedPlugins;
		}

		private void tlvPluginList_CellClick(object sender, CellClickEventArgs e)
		{
			RecordViewWindow.AddRecordData(e.Model);
		}

		private void btbFilter_TextChanged(object sender, EventArgs e)
		{
			FilterControl( ((TextBox)sender).Text);
		}

		private void tlvPluginList_Expanding(object sender, TreeBranchExpandingEventArgs e)
		{
			Expanding(e.Model);
		}
	}
}
