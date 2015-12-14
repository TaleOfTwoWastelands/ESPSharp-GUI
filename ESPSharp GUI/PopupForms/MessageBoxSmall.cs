using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ESPSharp_GUI.PopupForms
{
	/// <summary>
	/// Presents the user with an explanation for an action and the options to accept or cancel the action.
	/// Canceling will return DialogResult.Cancel, accepting will return DialogResult.OK
	/// </summary>
	public partial class MessageBoxSmall : Form
	{
		private DialogResult _result;

		public MessageBoxSmall(string text, string title = "")
		{
			InitializeComponent();

			tbLabel.Text = text;
			Text = title;
            ResizeForm();
		}


		public DialogResult GetResult()
		{
			return _result;
		}


		#region Private Methods
		private void ResizeForm()
		{
			var height = Height + (tbLabel.Lines.Count() * tbLabel.Font.Height) - tbLabel.Height;
			Size = new Size(Width, (int)height);
			Refresh();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			_result = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			_result = DialogResult.Cancel;
		}

		private void input_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.WindowsShutDown || e.CloseReason == CloseReason.UserClosing ||
			    e.CloseReason == CloseReason.TaskManagerClosing || e.CloseReason == CloseReason.FormOwnerClosing ||
			    e.CloseReason == CloseReason.ApplicationExitCall)
				_result = DialogResult.Cancel;
		}
		#endregion Private Methods
	}
}
