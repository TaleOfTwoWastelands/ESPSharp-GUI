using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ESPSharp_GUI.Controls
{
	public class ButtonTextBox : TextBox
	{
		private readonly Button _button;

		[PropertyTab("Events")]
		[Browsable(true)]
		[Description("Occurs when the button is pressed"), Category("Action")]
		public event EventHandler ButtonClick { add { _button.Click += value; } remove { _button.Click -= value; } }

		public ButtonTextBox()
		{
			_button = new Button { Cursor = Cursors.Default };
			_button.SizeChanged += (o, e) => OnResize(e);
			this.Controls.Add(_button);
			_button.Width = 25;
		}

		public Button Button => _button;

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			_button.Size = new Size(_button.Width, this.ClientSize.Height + 2);
			_button.Location = new Point(this.ClientSize.Width - _button.Width, -1);
			// Send EM_SETMARGINS to prevent text from disappearing underneath the button
			SendMessage(this.Handle, 0xd3, (IntPtr)2, (IntPtr)(_button.Width << 16));
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

	}
}
