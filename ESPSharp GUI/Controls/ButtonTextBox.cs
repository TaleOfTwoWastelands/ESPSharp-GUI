using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ESPSharp_GUI.Controls
{
	public class ButtonTextBox : TextBox
	{
		public Button Button { get; }

		#region Button

		#region Editor Properties
		[PropertyTab("Events")]
		[Category("Action")]
		[Browsable(true)]
		[Description("Occurs when the button is pressed")]
		public event EventHandler ButtonClick { add { Button.Click += value; } remove { Button.Click -= value; } }

		[PropertyTab("Properties")]
		[Category("Button")]
		[Browsable(true)]
		[Description("Width of the button in the text box")]
		public int ButtonWidth { get; set; } = 25;

		[PropertyTab("Properties")]
		[Category("Button")]
		[Browsable(true)]
		[Description("Image when the form is loaded.")]
		public Image DefaultImage { get { return Button.Image; } set { Button.Image = value; } }

		[PropertyTab("Properties")]
		[Category("Button")]
		[Browsable(true)]
		[Description("Image shown when there is no text in the textbox.")]
		public Image EmptyImage { get; set; }

		[PropertyTab("Properties")]
		[Category("Button")]
		[Browsable(true)]
		[Description("Image shown when there is text in the textbox.")]
		public Image ContentsImage { get; set; }
		#endregion Editor Properties

		public ButtonTextBox()
		{
			Button = new Button { Cursor = Cursors.Default };
			Button.SizeChanged += (o, e) => OnResize(e);
			Button.Click += delegate { Text = ""; };
			Button.Width = ButtonWidth;
			Button.FlatStyle = FlatStyle.Flat;
			Button.FlatAppearance.BorderSize = 0;
			Controls.Add(Button);

			TextChanged += delegate(object sender, EventArgs e)
			{
				if (!string.IsNullOrEmpty(Text)) Button.Image = ContentsImage;
				else Button.Image = EmptyImage;
			};

		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			Button.Size = new Size(Button.Width, ClientSize.Height + 2);
			Button.Location = new Point(ClientSize.Width - Button.Width, - 1);
			// Send EM_SETMARGINS to prevent text from disappearing underneath the button
			SendMessage(Handle, 0xd3, (IntPtr)2, (IntPtr)(Button.Width << 16));
		}

		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

		private void InitializeComponent()
		{
			this.SuspendLayout();
			this.ResumeLayout(false);

		}
		#endregion Button


		#region Prompt Text

		#region Editor Properties
		[PropertyTab("Properties")]
		[Category("Prompt")]
		[Browsable(true)]
		[Description("The prompt text to display when there is nothing in the Text property.")]
		public string PromptText
		{
			get { return _promptText; }
			set { _promptText = value.Trim(); Invalidate(); }
		}

		[PropertyTab("Properties")]
		[Category("Prompt")]
		[Browsable(true)]
		[Description("The ForeColor to use when displaying the PromptText.")]
		public Color PromptForeColor
		{
			get { return _promptColor; }
			set { _promptColor = value; Invalidate(); }
		}

		[PropertyTab("Properties")]
		[Category("Prompt")]
		[Browsable(true)]
		[Description("The Font to use when displaying the PromptText.")]
		public Font PromptFont
		{
			get { return _promptFont; }
			set { _promptFont = value; Invalidate(); }
		}
		#endregion Editor Properties

		// Windows message constants
		private const int WmSetfocus = 7;
		private const int WmKillfocus = 8;
		private const int WmPaint = 15;

		// private internal variables
		private bool _drawPrompt = true;
		private string _promptText = string.Empty;
		private Color _promptColor = SystemColors.GrayText;
		private Font _promptFont = DefaultFont;

		/// <summary>
		/// Redraw the control when the text alignment changes
		/// </summary>
		/// <param name="e"></param>
		protected override void OnTextAlignChanged(EventArgs e)
		{
			base.OnTextAlignChanged(e);
			this.Invalidate();
		}

		/// <summary>
		/// Redraw the control with the prompt
		/// </summary>
		/// <param name="e"></param>
		/// <remarks>This event will only fire if ControlStyles.UserPaint is set to true in the constructor</remarks>
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			// Only draw the prompt in the OnPaint event and when the Text property is empty
			if (_drawPrompt && Text.Length == 0)
				DrawTextPrompt(e.Graphics);
		}

		/// <summary>
		/// Overrides the default WndProc for the control
		/// </summary>
		/// <param name="m">The Windows message structure</param>
		/// <remarks>
		/// This technique is necessary because the OnPaint event seems to be doing some
		/// extra processing that I haven't been able to figure out.
		/// </remarks>
		protected override void WndProc(ref System.Windows.Forms.Message m)
		{
			switch (m.Msg)
			{
				case WmSetfocus:
					_drawPrompt = false;
					break;

				case WmKillfocus:
					_drawPrompt = true;
					break;
			}

			base.WndProc(ref m);

			// Only draw the prompt on the WmPaint event and when the Text property is empty
			if (m.Msg == WmPaint && _drawPrompt && Text.Length == 0 && !GetStyle(ControlStyles.UserPaint))
				DrawTextPrompt();
		}

		/// <summary>
		/// Overload to automatically create the Graphics region before drawing the text prompt
		/// </summary>
		/// <remarks>The Graphics region is disposed after drawing the prompt.</remarks>
		protected virtual void DrawTextPrompt()
		{
			using (Graphics g = CreateGraphics())
				DrawTextPrompt(g);
		}

		/// <summary>
		/// Draws the PromptText in the TextBox.ClientRectangle using the PromptFont and PromptForeColor
		/// </summary>
		/// <param name="g">The Graphics region to draw the prompt on</param>
		protected virtual void DrawTextPrompt(Graphics g)
		{
			var flags = TextFormatFlags.NoPadding | TextFormatFlags.Top | TextFormatFlags.EndEllipsis;
			var rect = ClientRectangle;

			// Offset the rectangle based on the HorizontalAlignment, 
			// otherwise the display looks a little strange
			switch (TextAlign)
			{
				case HorizontalAlignment.Center:
					flags = flags | TextFormatFlags.HorizontalCenter;
					rect.Offset(0, 1);
					break;
				case HorizontalAlignment.Left:
					flags = flags | TextFormatFlags.Left;
					rect.Offset(1, 1);
					break;
				case HorizontalAlignment.Right:
					flags = flags | TextFormatFlags.Right;
					rect.Offset(0, 1);
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}

			// Draw the prompt text using TextRenderer
			TextRenderer.DrawText(g, _promptText, _promptFont, rect, _promptColor, BackColor, flags);
		}
		#endregion Prompt Text
	}
}
