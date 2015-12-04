using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ESPSharp_GUI.Controls
{
	public class ButtonTextBox : TextBox
	{
		private readonly Button _button;

		[PropertyTab("Events")]
		[Browsable(true)]
		[Description("Occurs when the button is pressed"), Category("Action")]
		public event EventHandler ButtonClick { add { _button.Click += value; } remove { _button.Click -= value; } }

		[PropertyTab("Properties")]
		[Browsable(true)]
		[Description("Width of the button in the text box"), Category("Button")]
		public int ButtonWidth { get; set; } = 25;

		[PropertyTab("Properties")]
		[Browsable(true)]
		[Description("Image when the form is loaded."), Category("Button")]
		public Image DefaultImage { get { return _button.Image; } set { _button.Image = value; } }

		[PropertyTab("Properties")]
		[Browsable(true)]
		[Description("Image shown when there is no text in the textbox."), Category("Button")]
		public Image EmptyImage { get; set; }

		[PropertyTab("Properties")]
		[Browsable(true)]
		[Description("Image shown when there is text in the textbox."), Category("Button")]
		public Image ContentsImage { get; set; }

		public ButtonTextBox()
		{
			_button = new Button { Cursor = Cursors.Default };
			_button.SizeChanged += (o, e) => OnResize(e);
			_button.Click += delegate { Text = ""; };
			_button.Width = ButtonWidth;
			_button.FlatStyle = FlatStyle.Flat;
			_button.FlatAppearance.BorderSize = 0;
			Controls.Add(_button);

			TextChanged += delegate(object sender, EventArgs e)
			{
				if (!string.IsNullOrEmpty(Text)) _button.Image = ContentsImage;
				else _button.Image = EmptyImage;
			};

		}

		public Button Button => _button;

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			_button.Size = new Size(_button.Width, ClientSize.Height + 2);
			_button.Location = new Point(ClientSize.Width - _button.Width, - 1);
			// Send EM_SETMARGINS to prevent text from disappearing underneath the button
			SendMessage(Handle, 0xd3, (IntPtr)2, (IntPtr)(_button.Width << 16));
		}

		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

		private void InitializeComponent()
		{
			this.SuspendLayout();
			this.ResumeLayout(false);

		}
	}
}
