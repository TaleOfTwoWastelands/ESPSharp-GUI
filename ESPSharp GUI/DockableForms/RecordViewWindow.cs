using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using ESPSharp;
using ESPSharp_GUI.Interfaces;
using ESPSharp_GUI.Misc;
using ESPSharp_GUI.Utilities;
using WeifenLuo.WinFormsUI.Docking;

namespace ESPSharp_GUI.DockableForms
{
	public partial class RecordViewWindow : DockContent, IDockableForm
	{
		public static RecordViewWindow Instance => _instance ?? (_instance = new RecordViewWindow());
		private static RecordViewWindow _instance;

		public DockState DefaultState { get; } = DockState.Document;

		public RecordViewWindow()
		{
			InitializeComponent();


			
			treeListView1.ChildrenGetter = delegate (object x)
			{
				var r = x as RecordViewProperties;
				if (r?.Nodes.Count > 0)
					return r.Nodes;
				return new ArrayList();
			};
			treeListView1.GetColumn(0).AspectGetter = delegate (object x)
			{
				var r = x as RecordViewProperties;
				if (r != null)
					return r.Name;
				return "No name found";
			};
			treeListView1.GetColumn(1).AspectGetter = delegate (object x)
			{
				var r = x as RecordViewProperties;
				if (r != null && r.Nodes.Count == 0) return r.Value;
				return "";
			};
			treeListView1.TreeColumnRenderer.UseTriangles = true;
			treeListView1.TreeColumnRenderer.PIXELS_PER_LEVEL = 10;

			var p = new Pen(Color.Black) {DashPattern = new[] {0.5F, 0.8F}, Width = 0.5F};

			treeListView1.TreeColumnRenderer.LinePen = p;
		}

		private static void AddExpandGetter()
		{
			Instance.treeListView1.CanExpandGetter = x => (x is RecordViewProperties && ((RecordViewProperties)x).Nodes.Count > 0);
		}


		public static void AddRecordData(object o)
		{
			Record record = null;
			var master = new ElderScrollsPlugin();

			var plugin = o as ElderScrollsPlugin;
			if (plugin != null)
				record = plugin.Header.Record;

			var view = o as RecordView;
			if (view != null)
			{
				record = view.Record;
				master = PluginData.GetRecordViewMasterFile(view);

			}

			if (record == null)
			{
				Instance.textBox1.Text = "";
				return;
			}
			
			var xelem = record.WriteXML(master);
			Instance.textBox1.Text = xelem.ToString();

			// This is what it takes to draw a new
			AddExpandGetter();
			Instance.treeListView1.Roots = GetXmlTree(xelem.Root, new RecordViewProperties()).Nodes;
			Instance.treeListView1.ExpandAll();
			var parent = Instance.treeListView1.GetParent(Instance.treeListView1.SelectedObject);
			Instance.treeListView1.Columns[1].Text = master.FileName;
			//Instance.treeListView1.CanExpandGetter = null;
		}


		private static RecordViewProperties GetXmlTree(XElement elem, RecordViewProperties node)
		{
			if (!elem.Elements().Any()) return null;

			foreach (var xElement in elem.Elements())
			{
				var name = "";
				if (xElement.HasAttributes) name += xElement.FirstAttribute.Value + " - " + xElement.Name;
				else name += xElement.Name;

                var record = new RecordViewProperties(name, xElement.Value);
				node.Nodes.Add(record);
				GetXmlTree(xElement, record);
			}
			return node;
		}

		private void treeListView1_Expanding(object sender, BrightIdeasSoftware.TreeBranchExpandingEventArgs e)
		{
			
		}
	}
}
