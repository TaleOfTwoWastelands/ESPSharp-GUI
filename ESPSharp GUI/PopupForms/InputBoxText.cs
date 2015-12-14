using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ESPSharp_GUI.PopupForms
{
	/// <summary>
	/// Presents the user with an entry box for a line of text.
	/// Offers the option for design to set a label on the control explaining in detail what the input is for.
	/// Accepts a validator delegate that will be used to validate the entered text, and must return a bool.
	/// If validator is set to null it will just return the raw text value.
	/// If the user cancels or closes the box for any reason it will return an empty string as the result.
	/// </summary>
	public partial class InputBoxText : Form
	{
		public delegate bool ValidateEntry(string text);
		public event ValidateEntry EntryValidation;



		#region Constructors
		public InputBoxText(ValidateEntry validator)
		{
			InitializeComponent();
			if (validator != null) EntryValidation += validator;
			
			ResizeForm();
		}

		public InputBoxText(string label, ValidateEntry validator, string title) : this(validator)
		{
			if (!string.IsNullOrEmpty(title))
			tbLabel.Text = label;
			Name = title;
		}
		#endregion Constructors



		public string GetResult()
		{
			return tbInput.Text;
		}



		#region Private Methods
		private void ResizeForm()
		{
			// Label's height / line height = line count * line height - initial height
			var height = Height + (tbLabel.Lines.Count() * tbLabel.Font.Height) - tbLabel.Height;
			Size = new Size(Width, (int)height);
			Refresh();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			// If there's a validation function, check and only set if valid, otherwise assume all text is valid.
			if (EntryValidation != null)
			{
				if (!EntryValidation.Invoke(tbInput.Text))	// Validation fails.
				{
					MessageBox.Show("Invalid Entry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			Hide();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			tbInput.Text = "";
		}

		private void input_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.WindowsShutDown || e.CloseReason ==  CloseReason.UserClosing || e.CloseReason == CloseReason.TaskManagerClosing || e.CloseReason == CloseReason.FormOwnerClosing || e.CloseReason == CloseReason.ApplicationExitCall)
				tbInput.Text = "";
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				case (char) Keys.Enter:
					e.Handled = true;
					btnOk.PerformClick();
					break;
				case (char) Keys.Escape:
					e.Handled = true;
					btnCancel.PerformClick();
					break;
			}
		}
		#endregion  Private Methods
	}
}
