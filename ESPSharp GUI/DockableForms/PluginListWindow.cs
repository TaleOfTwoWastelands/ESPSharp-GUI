using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BrightIdeasSoftware;
using ESPSharp;
using ESPSharp_GUI.Controls;
using ESPSharp_GUI.Interfaces;
using ESPSharp_GUI.Utilities;
using WeifenLuo.WinFormsUI.Docking;

namespace ESPSharp_GUI.DockableForms
{
	public partial class PluginListWindow : DockContent, IDockableForm
	{
		public static PluginListWindow Instance => _instance ?? (_instance = new PluginListWindow());
		private static PluginListWindow _instance;

		public DockState DefaultState { get; } = DockState.DockLeft;

		public PluginListWindow()
		{
			InitializeComponent();
			SetDelegates();
		}

		/// <summary>
		/// Gets the loaded list of plugins and adds it to the tree view control
		/// </summary>
		public void UpdateList()
		{
			pluginTreeView.AddRootContents(ElderScrollsPlugin.LoadedPlugins);
		}



		/// <summary>
		/// Sets up the delegates for this window to communicate with it's tree view
		/// </summary>
		private void SetDelegates()
		{
			pluginTreeView.CellClick += delegate (object sender, CellClickEventArgs e)
			{ RecordViewWindow.AddRecordData(e.Model); };

			pluginTreeView.CellRightClick += delegate(object sender, CellRightClickEventArgs e)
			{
				if (e.Model == null) return;
				e.MenuStrip = DecideRightClickMenu(e.Model);
			};
		}

		private ContextMenuStrip DecideRightClickMenu(object model)
		{
			if (model is ElderScrollsPlugin)
				return cmsCellRightClickPlugin;
			if (model is Group)
				return cmsCellRightClickGroup;
			if (model is RecordView || model is Record)
				return cmsCellRightClickRecord;
			return null;
		}



		private void copyToBookmarksToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			BookmarkListWindow.Instance.AddToList(pluginTreeView.TlvControl.SelectedObjects);
		}

		private void copyAsOverrideToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			using (var input = new InputBoxText("Plugin name:"))
			{
				input.EntryValidation += delegate(string text)
				{
					if (text.IndexOfAny(Path.GetInvalidFileNameChars()) < 0 && !File.Exists(Path.Combine(Settings.DataPath, text))) return true;
					return false;
				};
				input.ShowDialog(this);

				var result = input.GetResult();


				var plugin = new ElderScrollsPlugin(result + ".esp");
			}
		}
	}
}
