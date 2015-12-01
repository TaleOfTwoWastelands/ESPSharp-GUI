using System.Xml.Linq;
using ESPSharp;
using ESPSharp_GUI.Utilities;
using WeifenLuo.WinFormsUI.Docking;

namespace ESPSharp_GUI.DockableForms
{
	public partial class RecordViewWindow : DockContent
	{
		public static RecordViewWindow Instance => _instance ?? (_instance = new RecordViewWindow());
		private static RecordViewWindow _instance;

		public RecordViewWindow()
		{
			InitializeComponent();
		}

		public static void AddRecordData(object o)
		{
			Record record = null;
			ElderScrollsPlugin master = new ElderScrollsPlugin();

			if (o is ElderScrollsPlugin)
			{
				record = ((ElderScrollsPlugin)o).Header.Record;
			}
			if (o is RecordView)
			{
				record = ((RecordView) o).Record;

				foreach (var p in PluginData.Plugins)
				{
					if (!p.RecordViews.Contains((RecordView)o)) continue;
					master = p;
					break;
				}
			}

			if (record == null)
			{
				Instance.textBox1.Text = "";
				return;
			}

			var xelem = new XElement("Filename");
			record.WriteDataXML(xelem, master);
			Instance.textBox1.Text = xelem.ToString();

		}
	}
}
