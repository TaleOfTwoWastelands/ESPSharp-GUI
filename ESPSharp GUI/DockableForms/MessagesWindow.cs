using System;
using System.Diagnostics;
using System.Drawing;
using ESPSharp_GUI.Interfaces;
using ESPSharp_GUI.Utilities;
using WeifenLuo.WinFormsUI.Docking;
using static System.String;

namespace ESPSharp_GUI.DockableForms
{
	public partial class MessagesWindow : DockContent, IMessageReceiver, IDockableForm
	{
		public static MessagesWindow Instance => _instance ?? (_instance = new MessagesWindow());
		private static MessagesWindow _instance;

		public DockState DefaultState { get; } = DockState.DockBottom;

		private static readonly Stopwatch Stopwatch = new Stopwatch();

		public MessagesWindow()
		{
			InitializeComponent();

			Messenger.AddListener(this);
			Stopwatch.Start();
		}

		#region Inherited from IMessageReceiver
		public void AddMessage(string msg)
		{
			if (InvokeRequired)
				Invoke(new Action<string>(WriteMessage), msg);
			else
				WriteMessage(msg);
		}

		public void AddInfo(string msg)
		{
			if (InvokeRequired)
				Invoke(new Action<string>(WriteInfo), msg);
			else
				WriteInfo(msg);
		}

		public void AddDebug(string msg)
		{
			throw new NotImplementedException();
		}

		public void AddWarning(string msg)
		{

			if (InvokeRequired)
				Invoke(new Action<string>(WriteWarning), msg);
			else
				WriteWarning(msg);
		}

		public void AddError(string msg, Exception ex = null)
		{
			if (InvokeRequired)
			{
				if (ex != null)
					Invoke(new Action<string>(WriteError), ex.Message);
				Invoke(new Action<string>(WriteError), msg);
			}
			else
				WriteError(msg);
		}
		#endregion Inherited from IMessageReceiver


		#region Write to text box
		private void WriteMessage(string msg)
		{
			rtbMessages.AppendText(FormatedTime());
			rtbMessages.AppendText(msg);
			rtbMessages.AppendText(Environment.NewLine);
		}

		private void WriteMessage(string msg, Color clr)
		{
			Instance.rtbMessages.AppendText(FormatedTime());

			var start = rtbMessages.TextLength;
			rtbMessages.AppendText(msg);
			var end = rtbMessages.TextLength;

			rtbMessages.Select(start, end - start);
			rtbMessages.SelectionColor = clr;
			rtbMessages.SelectionLength = 0;

			rtbMessages.AppendText(Environment.NewLine);
		}

		private void WriteInfo(string msg)
		{
			Divider();
			WriteMessage(msg);
			Divider();
		}

		private void WriteWarning(string msg)
		{
			WriteMessage(msg, Properties.Settings.Default.MessageWarningColor);
		}

		private void WriteError(string msg)
		{
			WriteMessage(msg, Properties.Settings.Default.MessageErrorColor);
		}
		#endregion Write to text box


		#region Internal extra methods
		private void Divider()
		{
			Instance.rtbMessages.AppendText(Environment.NewLine);
			Instance.rtbMessages.AppendText("==================================================");
			Instance.rtbMessages.AppendText(Environment.NewLine + Environment.NewLine);
		}

		private string FormatedTime()
		{
			return Format("[{0:D2}:{1:D2}] ", (int)Stopwatch.Elapsed.TotalMinutes, (int)Stopwatch.Elapsed.TotalSeconds);
		}
		#endregion Internal extra methods
	}
}
