using System;
using System.IO;
using System.Windows.Forms;
using BrightIdeasSoftware;
using ESPSharp_GUI.Extensions;

namespace ESPSharp_GUI.DockableForms
{
	public partial class BookmarkListWindow : PluginList
	{
		public static BookmarkListWindow Instance => _instance ?? (_instance = new BookmarkListWindow());
		private static BookmarkListWindow _instance;

		public BookmarkListWindow()
		{
			InitializeComponent();
			base.InitializeComponent();

			TlvControl = treeListView1;

			SetupTree();
			SetupDragAndDrop();
		}

		

		private void btbFilter_TextChanged(object sender, EventArgs e)
		{
			FilterControl(((TextBox)sender).Text);
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			treeListView1.ClearObjects();
		}

		private void tlvPluginList_CellClick(object sender, CellClickEventArgs e)
		{
			//RecordViewWindow.AddRecordData(e.Model);
		}

		private void tlvPluginList_Expanding(object sender, TreeBranchExpandingEventArgs e)
		{
			Expanding(e.Model);
		}

		private void tlvPluginsList_Collapsing(object sender, TreeBranchCollapsingEventArgs e)
		{
			Collapsing(e.Model);
		}
	}
}
