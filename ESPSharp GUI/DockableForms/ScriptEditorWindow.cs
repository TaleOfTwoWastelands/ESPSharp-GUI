using ESPSharp_GUI.Interfaces;
using WeifenLuo.WinFormsUI.Docking;

namespace ESPSharp_GUI.DockableForms
{
	public partial class ScriptEditorWindow : DockContent, IDockableForm
	{
		public static ScriptEditorWindow Instance => _instance ?? (_instance = new ScriptEditorWindow());
		private static ScriptEditorWindow _instance;

		public DockState DefaultState { get; } = DockState.Document;


		public ScriptEditorWindow()
		{
			InitializeComponent();
		}
	}
}
