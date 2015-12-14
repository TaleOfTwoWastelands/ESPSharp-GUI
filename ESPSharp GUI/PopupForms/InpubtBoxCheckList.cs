using System;
using System.Windows.Forms;

namespace ESPSharp_GUI.PopupForms
{
	public partial class InpubtBoxCheckList : Form
	{

		// This form should be a standardized checkbox input form.
		// Needs to take two lists, one of all items to display and one of checked items.
		// Returns a list of all items checked when the form closes.
		
		
		
		public InpubtBoxCheckList()
		{
			InitializeComponent();
		}



		public string GetResult()
		{
			return "";
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void input_FormClosing(object sender, FormClosingEventArgs e)
		{
			;
		}
	}
}
