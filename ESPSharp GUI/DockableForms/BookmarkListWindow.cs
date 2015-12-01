using System.Collections;
using System.IO;
using System.Windows.Forms;
using BrightIdeasSoftware;
using ESPSharp;
using WeifenLuo.WinFormsUI.Docking;

namespace ESPSharp_GUI.DockableForms
{
	public partial class BookmarkListWindow : DockContent
	{
		public static BookmarkListWindow Instance => _instance ?? (_instance = new BookmarkListWindow());
		private static BookmarkListWindow _instance;

		public BookmarkListWindow()
		{
			InitializeComponent();

			SetupTree();
			SetupDragAndDrop();
		}

		private void SetupTree()
		{
			treeListView1.CanExpandGetter = delegate (object x)
			{
				return (x is ElderScrollsPlugin || x is Group);
			};

			treeListView1.ChildrenGetter = delegate (object x)
			{
				if (x is ElderScrollsPlugin)
				{
					var p = x as ElderScrollsPlugin;
					return p.TopGroups;
				}
				else if (x is Group)
				{
					var g = x as Group;
					if (g.Children.Count == 0)
						return g.ChildRecordViews;
					return g.Children;
				}
				return new ArrayList();
			};

			treeListView1.GetColumn(0).AspectGetter = delegate (object x)
			{
				if (x is ElderScrollsPlugin)
					return (x as ElderScrollsPlugin).FileName;
				if (x is Group)
					return (x as Group).ToString();
				if (x is RecordView)
					return (x as RecordView).FormID;

				return new ArrayList();
			};

			treeListView1.GetColumn(1).AspectGetter = delegate (object x)
			{
				if (x is ElderScrollsPlugin || x is Group)
					return "";
				if (x is RecordView)
					return (x as RecordView).Record.ToString();
				return new ArrayList();
			};

			treeListView1.GetColumn(2).AspectGetter = delegate (object x)
			{
				if (x is ElderScrollsPlugin || x is Group)
					return "";
				if (x is RecordView)
					return (x as RecordView).Record.Tag;
				return new ArrayList();
			};
		}

		private void SetupDragAndDrop()
		{
			treeListView1.DragSource = new SimpleDragSource();
			treeListView1.DropSink = new RearrangingDropSink();

			treeListView1.ModelCanDrop += delegate (object sender, ModelDropEventArgs e) {
				e.Effect = DragDropEffects.None;
				if (e.TargetModel == null)
					return;

				if (e.TargetModel is DirectoryInfo)
					e.Effect = e.StandardDropActionFromKeys;
				else
					e.InfoMessage = "Can only drop on directories";
			};
		}

		private void onclick(object sender, System.EventArgs e)
		{
			if (0 == 1)
				return;
		}
	}
}
