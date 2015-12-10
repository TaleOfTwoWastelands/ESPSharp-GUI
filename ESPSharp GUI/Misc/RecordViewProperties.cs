using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPSharp_GUI.Misc
{
	class RecordViewProperties
	{
		public string Name;
		public string Value;
		public List<RecordViewProperties> Nodes;

		public RecordViewProperties()
		{
			Nodes = new List<RecordViewProperties>();
		}

		public RecordViewProperties(string name, string value)
		{
			Name = name;
			Value = value;
			Nodes = new List<RecordViewProperties>();
		}
	}
}
