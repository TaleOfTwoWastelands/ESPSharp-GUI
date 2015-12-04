using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using ESPSharp;
using ESPSharp_GUI.Utilities;
using Fasterflect;
using WeifenLuo.WinFormsUI.Docking;

namespace ESPSharp_GUI.Extensions
{
	public class PluginList : DockContent
	{
		internal TreeListView TlvControl = new TreeListView();

		internal void SetupTree()
		{
			TlvControl.CanExpandGetter = delegate (object x)
			{
				return (x is ElderScrollsPlugin || x is Group);
			};


			TlvControl.ChildrenGetter = delegate (object x)
			{
				if (x is ElderScrollsPlugin)
				{
					var p = (ElderScrollsPlugin)x;
					return p.TopGroups;
				}
				if (x is Group)
				{
					var g = (Group)x;
					if (g.Children.Count == 0)
						return g.ChildRecordViews;
					return g.Children;
				}
				return new ArrayList();
			};


			TlvControl.GetColumn(0).AspectGetter = delegate (object x)
			{
				if (x is ElderScrollsPlugin)
					return ((ElderScrollsPlugin)x).FileName;
				if (x is Group)
					return ((Group)x).ToString();
				if (x is RecordView)
					return ((RecordView)x).FormID;

				return new ArrayList();
			};


			TlvControl.GetColumn(1).AspectGetter = delegate (object x)
			{
				if (x is ElderScrollsPlugin)
					return "";
				if (x is Group)
				{
					if(x is CellGroup)
					{
						var r = ElderScrollsPlugin.LoadedRecordViews[((CellGroup) x).Cell.RawValue];
						return r?[0].Record.ToString();
					}
					return "";
				}
				if (x is RecordView)
					return ((RecordView)x).Record.ToString();
				return new ArrayList();
			};


			TlvControl.GetColumn(2).AspectGetter = delegate (object x)
			{
				if (x is ElderScrollsPlugin || x is Group)
					return "";
				if (x is RecordView)
					// Todo: Maybe find a better way than reflection to do this
					return ((RecordView) x).Record.TryGetPropertyValue("Name");
				return new ArrayList();
			};
		}


		internal void SetupDragAndDrop()
		{
			TlvControl.DragSource = new SimpleDragSource();
			TlvControl.DropSink = new RearrangingDropSink();

			TlvControl.ModelCanDrop += delegate (object sender, ModelDropEventArgs e) {
				e.Effect = DragDropEffects.None;
				if (e.TargetModel == null) return;
				e.InfoMessage = "Add to bookmark list.";
			};
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
		}

		/// <summary>
		/// Expands a given object as a model of the treelistview until it cannot expand further.
		/// </summary>
		/// <param name="e">The object model to expand from</param>
		internal void Expanding(object e)
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
				RecursiveExpand(TlvControl.GetChildren(m));
				TlvControl.Expand(m);
			}
		}
	}
}
