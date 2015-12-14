using System.Drawing;
using System.Windows.Forms;
using ESPSharp_GUI.Controls;
using ESPSharp_GUI.PopupForms;

namespace ESPSharp_GUI
{
	public partial class EspSharpGui : Form
	{
		public static EspSharpGui Instance;

		public MainWindow Main;

		public EspSharpGui()
		{
			InitializeComponent();

			Instance = this;
			Main = mainWindow1;

			Size = new Size(1400, 800);
		}


		public static string ShowUserInputText(string label, InputBoxText.ValidateEntry validator, string title = "")
		{
			using (var input = new InputBoxText(label, validator, title))
			{
				input.ShowDialog(Instance);
				return input.GetResult();
			}

		}

		public static DialogResult ShowUserMessage(string label, string title = "")
		{
			using (var input = new MessageBoxSmall(label, title))
			{
				input.ShowDialog(Instance);
				return input.GetResult();
			}

		}



	}
}
