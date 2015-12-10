using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;

namespace ESPSharp_GUI.Interfaces
{
	public interface IDockableForm
	{
		DockState DefaultState { get; }

		//event ProgressUpdateError OnProgressUpdateError;
	}
}
