using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPSharp;

namespace ESPSharp_GUI
{
	class Instance
	{
		private static Instance _instance;
		public static Instance Current => _instance ?? (_instance = new Instance());
	}
}
