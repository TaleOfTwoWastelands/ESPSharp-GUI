using System.Drawing;
using System.Windows.Forms;
using ESPSharp_GUI.Controls;

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
	}
}
