using BrightIdeasSoftware;
using ESPSharp;
using WeifenLuo.WinFormsUI.Docking;

namespace ESPSharp_GUI.DockableForms
{
	public partial class PluginListWindow : DockContent
	{
		public static PluginListWindow Instance => _instance ?? (_instance = new PluginListWindow());
		private static PluginListWindow _instance;

		public PluginListWindow()
		{
			InitializeComponent();

			pluginTreeView.CellClick += delegate(object sender, CellClickEventArgs x)
			{
				RecordViewWindow.AddRecordData(x.Model);
			};
		}

		public void UpdateList()
		{
			pluginTreeView.AddRootContents(ElderScrollsPlugin.LoadedPlugins);
		}
	}
}
