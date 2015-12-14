using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ESPSharp_GUI.DockableForms;
using ESPSharp_GUI.Interfaces;
using ESPSharp_GUI.PopupForms;
using ESPSharp_GUI.Utilities;
using ESPSharp_GUI.Windows;
using WeifenLuo.WinFormsUI.Docking;

namespace ESPSharp_GUI.Controls
{
	public partial class MainWindow : UserControl
	{
		#region Members
		public DockPanel DpMainPanel => dpMainPanel;

		public Dictionary<string, DockContent> DockableForms { get; } = new Dictionary<string, DockContent>();
		#endregion Members


		public MainWindow()
		{
			InitializeComponent();
			
			AddDockableForm(PluginListWindow.Instance.Name, PluginListWindow.Instance, true);
			AddDockableForm(BookmarkListWindow.Instance.Name, BookmarkListWindow.Instance, true);
			AddDockableForm(MessagesWindow.Instance.Name, MessagesWindow.Instance, true);
			AddDockableForm(RecordViewWindow.Instance.Name, RecordViewWindow.Instance, true);
			AddDockableForm(LoadListWindow.Instance.Name, LoadListWindow.Instance, true);

			AddDockableForm(PreferencesWindow.Instance.Name, PreferencesWindow.Instance);
		}


		/// <summary>
		/// Adds a dockable form to the dockable forms dictionary. Optionally enables that form.
		/// </summary>
		/// <param name="name">The unique name key for the form.</param>
		/// <param name="panel">A new instance of a dockable form.</param>
		/// <param name="defaultActivate">Optional: Add the form to the panel at startup.</param>
		/// <returns></returns>
		public bool AddDockableForm(string name, DockContent panel, bool defaultActivate = false)
		{
			if (DockableForms.ContainsKey(name)) return false;

			if (!(panel is IDockableForm)) throw new InvalidCastException("The form does not implement IDockableForm");

			DockableForms.Add(name, panel);
			if (defaultActivate)
				ActivatePanel(name, ((IDockableForm)panel).DefaultState);
			return true;
		}

		/// <summary>
		/// Shows a dockable form in the dock panel, with the default DockState of Document.
		/// </summary>
		/// <param name="name">Key of the dockable form to show.</param>
		public void ActivatePanel(string name)
		{
			DockableForms[name].Show(DpMainPanel, DockState.Document);
		}

		/// <summary>
		/// Shows a dockable form in the dock panel, using the form's default DockState.
		/// </summary>
		/// <param name="name">Key of the dockable form to show.</param>
		/// <param name="state">DockState to open the form in.</param>
		public void ActivatePanel(string name, DockState state)
		{
			DockableForms[name].Show(DpMainPanel, state);
		}



		#region Menu Strip

		private void tsmi_Hover(object sender, System.EventArgs e)
		{
			if (!(sender is ToolStripDropDownItem)) return;

			var item = (ToolStripDropDownItem)sender;
			if (item.HasDropDownItems && !item.DropDown.Visible)
				item.ShowDropDown();
		}


		#region File Menu
		private void tsmiReloadPlugins_Click(object sender, EventArgs e)
		{
			LoadListWindow.Instance.Activate();
		}

		private void tsmiPreferences_Click(object sender, System.EventArgs e)
		{
			ActivatePanel("PreferencesWindow");
		}
		#endregion File Menu


		#region View Menu

		#endregion View Menu


		#region Help Menu
		private void tsmiHelp_Click(object sender, EventArgs e)
		{
			var about = new AboutBox1();
			about.ShowDialog(this);
		}
		#endregion Help Menu

		#endregion Menu Strip

		private void testButtonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			;
		}
	}
}
