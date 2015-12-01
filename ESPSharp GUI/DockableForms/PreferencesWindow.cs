using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ESPSharp_GUI.DockableForms
{
	public partial class PreferencesWindow : DockContent
	{
		public static PreferencesWindow Instance => _instance ?? (_instance = new PreferencesWindow());
		private static PreferencesWindow _instance;


		public PreferencesWindow()
		{
			InitializeComponent();
		}

		public void Apply()
		{
			//foreach (var prefDgvValues in GetDgvValues())
			//	Settings.Setting.PluginSearchLocations.AddLocation(prefDgvValues.Game, prefDgvValues.Recursive.ToString(),
			//		prefDgvValues.Directory);

			//EspSharpSettings.Save();
			//MessagesWindow.WriteMessage("Setting Saved!");
		}




		#region DataGridView
		private bool DgvIsRowValid(DataGridViewRow row)
		{
			if (!string.IsNullOrEmpty(row.Cells[0].Value as string))
				if (!string.IsNullOrEmpty(row.Cells[2].Value as string))
					return true;


			return false;
		}

		private List<PrefDgvValues> GetDgvValues()
		{
			var values = new List<PrefDgvValues>();
			foreach (DataGridViewRow row in PrefDgvLocations.Rows)
			{
				if (!DgvIsRowValid(row) || row.IsNewRow) continue;

				values.Add(new PrefDgvValues() {Game = row.Cells[0].Value as string, Recursive = (bool)row.Cells[1].Value, Directory = row.Cells[2].Value as string });
			}
			return values;
		}

		private void DgvButtonAdd_Click(object sender, EventArgs e)
		{
			PrefDgvLocations.Rows.Add(new DataGridViewRow());
		}

		private void DgvButtonRemove_Click(object sender, EventArgs e)
		{
			if (PrefDgvLocations.SelectedRows.Count <= 0) return;

			var removeList = new List<DataGridViewRow>();

			removeList.AddRange(PrefDgvLocations.SelectedRows.Cast<DataGridViewRow>().Where(row => !row.IsNewRow));

			foreach (var row in removeList)
				PrefDgvLocations.Rows.Remove(row);
		}

		private void PrefDgvLocations_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// Begin editing a cell on click
			PrefDgvLocations.BeginEdit(true);
		}
		#endregion DataGridView



		#region Form Actions
		private void Preferences_Load(object sender, EventArgs e)
		{
			// Populate the dgv
			//for (int index = 0; index < EspSharpSettings.Settings.PluginSearchLocations.LocalDirectory.Count; index++)
			//{
			//	var settingsLocalDirectory = EspSharpSettings.Settings.PluginSearchLocations.LocalDirectory[index];
			//	PrefDgvLocations.Rows.Add();
			//	PrefDgvLocations.Rows[index].Cells[0].Value = settingsLocalDirectory.GameField;
			//	PrefDgvLocations.Rows[index].Cells[1].Value = settingsLocalDirectory.Recursive;
			//	PrefDgvLocations.Rows[index].Cells[2].Value = settingsLocalDirectory.Directory;
			//}
		}

		private void Preferences_FormClosing(object sender, FormClosingEventArgs e)
		{
			Apply();
		}

		private void PrefBtnApply_Click(object sender, EventArgs e)
		{
			Apply();
		}
		#endregion Form Actions
	}



	public struct PrefDgvValues
	{
		public string Game;
		public string Directory;
		public bool Recursive;
	}

}
