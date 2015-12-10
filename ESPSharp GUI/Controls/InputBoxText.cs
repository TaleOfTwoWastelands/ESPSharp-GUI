using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESPSharp_GUI.Controls
{
	public partial class InputBoxText : Form
	{
		public delegate bool ValidateEntry(string text);
		public event ValidateEntry EntryValidation;

		private string _result;


		public InputBoxText(string title, string label)
		{
			InitializeComponent();
			
			Name = title;
			label1.Text = label;

			ResizeForm();
		}

		public InputBoxText(string label)
		{
			InitializeComponent();
			
			label1.Text = label;

			ResizeForm();
		}

		public string GetResult()
		{
			return _result;
		}

		private void ResizeForm()
		{
			// Label's height / line height = line count * line height - initial height
			var height = Height + ((label1.Height / 13)) * 13 - 13;
			Size = new Size(Width, height);
			Refresh();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			// If there's a validation function, check and only set if valid, otherwise assume all text is valid.
			if (EntryValidation != null)
			{
				if (!EntryValidation.Invoke(tbInput.Text))
				{
					MessageBox.Show("Invalid Entry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			// Todo: For some reason this is behaving like it was never set when called later. Find out why
			_result = tbInput.Text;
			Hide();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void input_FormClosing(object sender, FormClosingEventArgs e)
		{
			_result = "";
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				case (char)Keys.Enter:
					e.Handled = true;
					btnOk.PerformClick();
					break;
				case (char) Keys.Escape:
					e.Handled = true;
					btnCancel.PerformClick();
					break;
			}
		}
	}
}
