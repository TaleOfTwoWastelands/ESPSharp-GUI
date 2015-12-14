using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BrightIdeasSoftware;
using ESPSharp;
using ESPSharp_GUI.Controls;
using ESPSharp_GUI.Interfaces;
using ESPSharp_GUI.PopupForms;
using ESPSharp_GUI.Utilities;
using WeifenLuo.WinFormsUI.Docking;


// How to modify cell font, will need to be done on every draw/format operation.
// Lookup needs to be fast, prefered dictionary or hash table of modified records for O(n)
// var font = pluginTreeView.TlvControl.SelectedItem.Font;
// pluginTreeView.TlvControl.SelectedItem.Font = new Font(font, FontStyle.Bold);



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
			pluginTreeView.CellClick += delegate(object sender, CellClickEventArgs e)
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
			InputBoxText.ValidateEntry validator = delegate (string text)
			{
				if (text.IndexOfAny(Path.GetInvalidFileNameChars()) < 0 && !File.Exists(Path.Combine(Settings.DataPath, text))) return true;
				return false;
			};
			var result = EspSharpGui.ShowUserInputText("Plugin name:", validator);

			var plugin = new ElderScrollsPlugin(result + ".esp");
		}
	}
}
