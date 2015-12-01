using System;
using System.Diagnostics;
using System.Drawing;
using WeifenLuo.WinFormsUI.Docking;
using static System.String;

namespace ESPSharp_GUI.DockableForms
{
	public partial class MessagesWindow : DockContent
	{
		public static MessagesWindow Instance => _instance ?? (_instance = new MessagesWindow());
		private static MessagesWindow _instance;
		
		private static readonly Stopwatch Stopwatch = new Stopwatch();

		public MessagesWindow()
		{
			InitializeComponent();
			Stopwatch.Start();
		}

		public static void WriteMessage(string str)
		{
			Instance.rtbMessages.AppendText(FormatedTime());
			Instance.rtbMessages.AppendText(str);
			Instance.rtbMessages.AppendText(Environment.NewLine);
		}

		public static void WriteMessage(string str, Color clr)
		{
			Instance.rtbMessages.AppendText(FormatedTime());

			var start = Instance.rtbMessages.TextLength;
			Instance.rtbMessages.AppendText(str);
			var end = Instance.rtbMessages.TextLength;

			Instance.rtbMessages.Select(start, end - start);
			Instance.rtbMessages.SelectionColor = clr;
			Instance.rtbMessages.SelectionLength = 0;

			Instance.rtbMessages.AppendText(Environment.NewLine);
		}

		public static void WriteWarning(string str)
		{
			str = "Warning: " + str;
			WriteMessage(str, Properties.Settings.Default.MessageWarningColor);
		}

		public static void WriteError(string str)
		{
			str = "Error: " + str;
			WriteMessage(str, Properties.Settings.Default.MessageErrorColor);
		}

		public static void Divider()
		{
			Instance.rtbMessages.AppendText(Environment.NewLine);
			Instance.rtbMessages.AppendText("==================================================");
			Instance.rtbMessages.AppendText(Environment.NewLine);
		}

		private static string FormatedTime()
		{
			return Format("[{0:D2}:{1:D2}] ", (int)Stopwatch.Elapsed.TotalMinutes, (int)Stopwatch.Elapsed.TotalSeconds);
		}

	}
}
