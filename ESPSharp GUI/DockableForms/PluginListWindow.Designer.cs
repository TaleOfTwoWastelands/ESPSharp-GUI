namespace ESPSharp_GUI.DockableForms
{
	partial class PluginListWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pluginTreeView = new ESPSharp_GUI.Controls.PluginTreeView();
			this.SuspendLayout();
			// 
			// pluginTreeView
			// 
			this.pluginTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pluginTreeView.Location = new System.Drawing.Point(0, 0);
			this.pluginTreeView.Name = "pluginTreeView";
			this.pluginTreeView.Size = new System.Drawing.Size(502, 262);
			this.pluginTreeView.TabIndex = 0;
			// 
			// PluginListWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 262);
			this.CloseButton = false;
			this.CloseButtonVisible = false;
			this.Controls.Add(this.pluginTreeView);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HideOnClose = true;
			this.Name = "PluginListWindow";
			this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
			this.TabText = "Loaded Mods";
			this.Text = "Loaded Mods";
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.PluginTreeView pluginTreeView;
	}
}