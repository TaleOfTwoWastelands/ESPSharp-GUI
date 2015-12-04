using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
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

			treeListView1.GetColumn(0).AspectGetter = delegate (object x)
			{
				var o = x as Record;
				if (o != null)
					return o.FormID;

				var p = x as PropertyInfo;
				if (p != null)
					return p.Name;

				return new ArrayList();
			};
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

			var xelem = new XElement("Filename");
			record.WriteDataXML(xelem, master);
			Instance.textBox1.Text = xelem.ToString();

			Instance.treeListView1.Roots = record.GetType().GetProperties();
			Instance.treeListView1.RefreshObjects(record.GetType().GetProperties());

			var temp = GetAllProperiesOfObject(record);
		}

		public static string GetAllProperiesOfObject(object thisObject)
		{
			string result = string.Empty;
			try
			{
				// get all public static properties of MyClass type
				var propertyInfos = thisObject.GetType().GetProperties(
      BindingFlags.Public | BindingFlags.NonPublic // Get public and non-public
    | BindingFlags.Static | BindingFlags.Instance  // Get instance + static
    | BindingFlags.FlattenHierarchy); // Search up the hierarchy
																											  // sort properties by name
				Array.Sort(propertyInfos,
						   (propertyInfo1, propertyInfo2) => propertyInfo1.Name.CompareTo(propertyInfo2.Name));

				// write property names
				StringBuilder sb = new StringBuilder();
				sb.Append("<" + thisObject.GetType().Name + ">");
				foreach (PropertyInfo propertyInfo in propertyInfos)
				{
					//sb.AppendFormat("Name: {0} | Value: {1} <br>", propertyInfo.Name, propertyInfo.va);
				}
				sb.Append("<hr />");
				result = sb.ToString();
			}
			catch (Exception exception)
			{
				// to do log it
			}

			return result;
		}


		private static List<RecordViewProperties> Add(object record)
		{
			if (record == null) return null;

			var propNames = new List<RecordViewProperties>();

			var properties = record.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);

			var types = record.GetType().GetNestedTypes();

			//foreach (var property in properties)
			//{
			//	var prop = new RecordViewProperties(property.Name);
			//	propNames.Add(prop);
			//	if (property.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public).Length > 0)
			//		prop.Subs = Add(property);
			//}


			return propNames;



			//	foreach (var propertyInfo in record.GetType().GetProperties())
			//	{
			//		propertyInfo.
			//	}




			//	// Is item an array or container of objects?
			//	// i.e. if it implements IEnumerable we can enumerate over
			//	// the objects to see if they can be added to the tree.
			//	IEnumerable enumerableObject = record as IEnumerable;
			//	if (enumerableObject != null)
			//	{
			//		foreach (object itemInEnumerable in enumerableObject)
			//		{
			//			Add<TAttribute>(itemInEnumerable, treeNode, sPropertyForText);
			//		}
			//	}
			//	// Get the item’s properties and see if
			//	// there are any that have the attribute TreeNodeAttribute assigned to it
			//	PropertyInfo[] propertyInfos = record.GetType().GetProperties();
			//	foreach (PropertyInfo propertyInfo in propertyInfos)
			//	{
			//		// Check all attribs available on the property
			//		object[] attribs = propertyInfo.GetCustomAttributes(false);
			//		foreach (TAttribute treeNodeAttribute in attribs)
			//		{
			//			// Try and add the return value of the property to the tree,
			//			// if the property returns null it will be caught at the
			//			// beginning of this method.
			//			Add<TAttribute>(propertyInfo.GetValue(record, null),
			//				treeNode, sPropertyForText);
			//		}
			//	}
		}
	}

	class RecordViewProperties
	{
		public string Name;
		public List<RecordViewProperties> Subs;

		public RecordViewProperties(string name)
		{
			Name = name;
			Subs = new List<RecordViewProperties>();
		}
	}
}
