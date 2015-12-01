using System;
using System.Collections;
using System.Windows.Forms;
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

			SetupTree();
			SetupDragAndDrop();
			
		}

		private void SetupTree()
		{
			tlvPluginList.CanExpandGetter = delegate (object x)
			{
				return (x is ElderScrollsPlugin || x is Group);
			};

			tlvPluginList.ChildrenGetter = delegate (object x)
			{
				if (x is ElderScrollsPlugin)
				{
					var p = (ElderScrollsPlugin) x;
					return p.TopGroups;
				}
				else if (x is Group)
				{
					var g = (Group) x;
					if (g.Children.Count == 0)
						return g.ChildRecordViews;
					return g.Children;
				}
				return new ArrayList();
			};

			tlvPluginList.GetColumn(0).AspectGetter = delegate (object x)
			{
				if (x is ElderScrollsPlugin)
					return ((ElderScrollsPlugin) x).FileName;
				if (x is Group)
					return ((Group) x).ToString();
				if (x is RecordView)
					return ((RecordView) x).FormID;

				return new ArrayList();
			};

			tlvPluginList.GetColumn(1).AspectGetter = delegate (object x)
			{
				if (x is ElderScrollsPlugin || x is Group)
					return "";
				if (x is RecordView)
					return ((RecordView) x).Record.ToString();
				return new ArrayList();
			};

			tlvPluginList.GetColumn(2).AspectGetter = delegate (object x)
			{
				if (x is ElderScrollsPlugin || x is Group)
					return "";
				if (x is RecordView)
					return ((RecordView) x).Record.Tag;
				return new ArrayList();
			};
		}

		private void SetupDragAndDrop()
		{
			
		}

		public void UpdateList()
		{
			tlvPluginList.Roots = ElderScrollsPlugin.LoadedPlugins;
		}

		private void tbFilter_TextChanged(object sender, System.EventArgs e)
		{
			var txt = ((TextBox) sender).Text;
            TextMatchFilter filter = null;
			if (!String.IsNullOrEmpty(txt))
				filter = TextMatchFilter.Contains(tlvPluginList, txt);

			tlvPluginList.ModelFilter = filter;

			// Text highlighting requires at least a default renderer
			if (tlvPluginList.DefaultRenderer == null)
				tlvPluginList.DefaultRenderer = new HighlightTextRenderer(filter);
		}

		private void tlvPluginList_CellClick(object sender, CellClickEventArgs e)
		{
			RecordViewWindow.AddRecordData(e.Model);
		}
	}
}
