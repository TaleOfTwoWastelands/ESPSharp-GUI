using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ESPSharp_GUI.DockableForms;
using WeifenLuo.WinFormsUI.Docking;
using System.Text;

namespace ESPSharp_GUI
{
	public partial class MainWindow : Form
	{
		public static MainWindow Instance;

		#region Members
		private List<DockPane> _openPanes = new List<DockPane>();


		#endregion Members


		public MainWindow()
		{
			InitializeComponent();
			Instance = this;

			dpMainPanel.Theme = new VS2003Theme();

			PluginListWindow.Instance.Show(dpMainPanel, DockState.DockLeft);
			BookmarkListWindow.Instance.Show(dpMainPanel, DockState.DockLeftAutoHide);
			MessagesWindow.Instance.Show(dpMainPanel, DockState.DockBottom);
			PreferencesWindow.Instance.Show(dpMainPanel, DockState.Document);
			RecordViewWindow.Instance.Show(dpMainPanel, DockState.Document);
			LoadListWindow.Instance.Show(dpMainPanel, DockState.Document);

			// Set plugins list as active since it usually needs to be used first
			LoadListWindow.Instance.Activate();
		}

		private void tsmiPreferences_Click(object sender, System.EventArgs e)
		{
			if (dpMainPanel.Contents.Contains(PreferencesWindow.Instance))
				PreferencesWindow.Instance.DockHandler.Activate();
			else
				PreferencesWindow.Instance.Show(dpMainPanel, DockState.Document);
		}

		private void dpMainPanel_ContentAdded(object sender, DockContentEventArgs e)
		{
			//foreach (var pane in dpMainPanel.Panes)
			//{
			//	if (OpenPanes.Contains(pane)) continue;
			//	OpenPanes.Add(pane);
			//	var tsmi = new ToolStripMenuItem(pane.CaptionText);
			//	tsmi.Click += tsmiDynamicPanelFocus_Click;
			//	tsmiActivePanels.DropDownItems.Add(tsmi);
			//}
		}

		private void tsmiDynamicPanelFocus_Click(object sender, System.EventArgs e)
		{
			foreach (var item in dpMainPanel.Contents)
			{
				if (!item.DockHandler.Form.Text.Equals((sender as ToolStripMenuItem).Text)) continue;
				item.DockHandler.Activate();
				break;
			}
		}

		private void tsmi_Hover(object sender, System.EventArgs e)
		{
			if (sender is ToolStripDropDownItem)
			{
				ToolStripDropDownItem item = sender as ToolStripDropDownItem;
				if (item.HasDropDownItems && !item.DropDown.Visible)
				{
					item.ShowDropDown();
				}
			}
		}

		private void dpMainPanel_ActiveContentChanged(object sender, EventArgs e)
		{
			var form = (Form) sender;

			
		}

		private void tsmiReloadPlugins_Click(object sender, EventArgs e)
		{
			LoadListWindow.Instance.Activate();
		}
	}
}
