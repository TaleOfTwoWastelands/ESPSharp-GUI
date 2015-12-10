using System.Collections;
using System.Windows.Forms;
using BrightIdeasSoftware;
using ESPSharp_GUI.Interfaces;
using WeifenLuo.WinFormsUI.Docking;

namespace ESPSharp_GUI.DockableForms
{
	public partial class BookmarkListWindow : DockContent, IDockableForm
	{
		public static BookmarkListWindow Instance => _instance ?? (_instance = new BookmarkListWindow());
		private static BookmarkListWindow _instance;

		public DockState DefaultState { get; } = DockState.DockLeftAutoHide;

		public BookmarkListWindow()
		{
			InitializeComponent();


			pluginTreeView.SetupDragAndDrop();

			pluginTreeView.ModelCanDrop += delegate (object sender, ModelDropEventArgs e) {
				e.Effect = DragDropEffects.None;
				if (e.TargetModel == null) return;
				e.InfoMessage = "Add to bookmark list.";
			};
		}

		public void AddToList(IList model)
		{
			pluginTreeView.AddRootContents(model);
		}
	}
}
