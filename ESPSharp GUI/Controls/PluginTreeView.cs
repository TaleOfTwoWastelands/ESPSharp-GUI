using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using ESPSharp;
using Fasterflect;

namespace ESPSharp_GUI.Controls
{
	public partial class PluginTreeView : UserControl
	{
		/// <summary>
		/// The control's instance of the TreeListView
		/// </summary>
		public TreeListView TlvControl;


		private Collection<object> RootItems = new Collection<object>();



		#region Public Methods
		public PluginTreeView()
		{
			InitializeComponent();
			TlvControl = tlvPluginList;

			SetupTree();
		}

		/// <summary>
		/// Configures the tree with appropriate settings to handle plugins, groups, and recordviews.
		/// </summary>
		public void SetupTree()
		{
			// Todo: This whole method is really nasty and pretty hard to even look at. Should really come up with a better way to do this if possible.
			
			// Which groups can have children
			TlvControl.CanExpandGetter = x => (x is ElderScrollsPlugin || x is Group);

			// What to look at to get the children of an object
			TlvControl.ChildrenGetter = delegate (object x)
			{
				var plugin = x as ElderScrollsPlugin;
				if (plugin != null) return plugin.TopGroups;

				var group = x as Group;
				if (group != null)
				{
					if (group.Children.Count == 0)
						return group.ChildRecordViews;
					return group.Children;
				}

				return new ArrayList();
			};

			// How to fill in column 0 - FormID
			TlvControl.GetColumn(0).AspectGetter = delegate (object x)
			{
				var plugin = x as ElderScrollsPlugin;
				if (plugin != null) return plugin.FileName;

				var group = x as Group;
				if (group != null) return group.ToString();

				var recordView = x as RecordView;
				if (recordView != null) return recordView.FormID;

				return new ArrayList();
			};

			// How to fill in column 1 - EditorID
			TlvControl.GetColumn(1).AspectGetter = delegate (object x)
			{
				var plugin = x as ElderScrollsPlugin;
				if (plugin != null) return "";

				var group = x as Group;
				if (group != null)
				{
					if (group is CellGroup)
					{
						var r = ElderScrollsPlugin.LoadedRecordViews[((CellGroup)x).Cell.RawValue];
						return r?[0].Record.ToString();
					}
					if (group is WorldGroup)
					{
						var r = ElderScrollsPlugin.LoadedRecordViews[((WorldGroup)group).Worldspace.RawValue];
						return r?[0].Record.ToString();
					}
					if (group is TopicGroup)
					{
						var r = ElderScrollsPlugin.LoadedRecordViews[((TopicGroup)group).Topic.RawValue];
						return r?[0].Record.ToString();
					}
					return "";
				}

				var recordView = x as RecordView;
				if (recordView != null)
					return recordView.Record.ToString();

				return new ArrayList();
			};

			// How to fill in column 2 - Name
			TlvControl.GetColumn(2).AspectGetter = delegate (object x)
			{
				if (x is ElderScrollsPlugin || x is Group) return "";

				// Todo: Maybe find a better way than reflection to do this
				if (x is RecordView)
					return ((RecordView)x).Record.TryGetPropertyValue("Name");

				return new ArrayList();
			};

			// TODO: implement parent getter once records can see who their parents are
			//TlvControl.ParentGetter = delegate(object x)
			//{


			//};
		}

		/// <summary>
		/// Adds DragSource and DropSink to allow drag and drop
		/// </summary>
		public void SetupDragAndDrop()
		{
			TlvControl.DragSource = new SimpleDragSource();
			TlvControl.DropSink = new RearrangingDropSink();
		}

		/// <summary>
		/// Adds an IEnumerable as the roots of the TreeListView.
		/// </summary>
		/// <param name="contents">The IEnumerable that contains objects for the tree to display.</param>
		public void AddRootContents(IList contents)
		{
			foreach (var content in contents.Cast<object>().Where(content => !RootItems.Contains(content)))
				RootItems.Add(content);
			tlvPluginList.Roots = RootItems;
		}

		#endregion Public Methods



		#region Tree Events
		/// <summary>
		/// Triggered when a cell is left clicked
		/// </summary>
		public event EventHandler<CellClickEventArgs> CellClick
		{
			add { TlvControl.CellClick += value; }
			remove { TlvControl.CellClick -= value;  }
		}

		/// <summary>
		/// This event is triggered when the user moves a drag over
		/// an ObjectListView that has a SimpleDropSink installed as
		/// the drop handler, and when the source control for the 
		/// drag was an ObjectListView.
		/// </summary>
		public event EventHandler<ModelDropEventArgs> ModelCanDrop
		{
			add { TlvControl.ModelCanDrop += value; }
			remove { TlvControl.ModelCanDrop -= value; }
		}

		/// <summary>
		/// Triggered when a cell is right clicked.
		/// </summary>
		public event EventHandler<CellRightClickEventArgs> CellRightClick
		{
			add { TlvControl.CellRightClick += value; }
			remove { TlvControl.CellRightClick -= value; }
		}


		#region Events - Expanding and Collapsing
		private void tlvPluginList_Expanding(object sender, TreeBranchExpandingEventArgs e)
		{
			if (ModifierKeys == Keys.Control)
				if (TlvControl.CanExpand(e))
					RecursiveExpand(TlvControl.GetChildren(e));
		}

		private void tlvPluginsList_Collapsing(object sender, TreeBranchCollapsingEventArgs e)
		{
			if (ModifierKeys == Keys.Control)
				if (TlvControl.CanExpand(e))
					RecursiveExpand(TlvControl.GetChildren(e));
		}

		/// <summary>
		/// Recursively expands a group in the treelistview
		/// control until it cannot expand further
		/// </summary>
		/// <param name="ienum">The successive children to check for expansion</param>
		internal void RecursiveExpand(IEnumerable ienum)
		{
			foreach (var m in from object m in ienum where TlvControl.CanExpand(m) select m)
			{
				TlvControl.Expand(m);
				RecursiveExpand(TlvControl.GetChildren(m));
			}
		}

		/// <summary>
		/// Recursively collapses a group in the TreeListView
		/// control until it cannot collapse further. Prevents
		/// re-expansion from taking a long time.
		/// </summary>
		/// <param name="ienum"></param>
		internal void RecursiveCollapse(IEnumerable ienum)
		{
			foreach (var m in from object m in ienum where TlvControl.CanExpand(m) select m)
			{
				RecursiveCollapse(TlvControl.GetChildren(m));
				TlvControl.Collapse(m);
			}
		}
		#endregion Events - Expanding and Collapsing

		#endregion Tree Events



		#region Text Box Events
		private void btbFilter_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				FindInPlugins();
			e.Handled = true;
		}
		#endregion Text Box Events



		#region Button Events

		#endregion Button Events




		/// <summary>
		/// Gets the input from the search box and tries to parse it as a Hex value.
		/// If a valid hex value is found, search as FormID.
		/// If not a hex value, then search as an EditorID.
		/// </summary>
		private void FindInPlugins()
		{
			uint formId;
			var validFormId = uint.TryParse(btbFilter.Text, NumberStyles.HexNumber, null, out formId);
			if (validFormId)
			{
				var toFind = ElderScrollsPlugin.LoadedRecordViews[formId];
				TlvControl.Reveal(toFind[0], true);
			}
			// TODO: EditorID searching needs to be implemented in ESP# before it can be done here.
		}



		// Todo: this just refuses to work
		internal void FilterControl(string txt)
		{
			TextMatchFilter filter = null;
			if (!string.IsNullOrEmpty(txt))
				filter = TextMatchFilter.Contains(TlvControl, txt);

			// Text highlighting requires at least a default renderer
			if (TlvControl.DefaultRenderer == null)
				TlvControl.DefaultRenderer = new HighlightTextRenderer(filter);

			TlvControl.AdditionalFilter = filter;

			//TlvControl.Reveal();
		}
	}
}
