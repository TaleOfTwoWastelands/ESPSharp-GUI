namespace ESPSharp_GUI
{
	partial class MainWindow
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
			this.dpMainPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSelectGame = new System.Windows.Forms.ToolStripMenuItem();
			this.falloutNewVegasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fallout4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPreferences = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiActivePanels = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPanels = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiReloadPlugins = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// dpMainPanel
			// 
			this.dpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dpMainPanel.DockLeftPortion = 0.35D;
			this.dpMainPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
			this.dpMainPanel.Location = new System.Drawing.Point(0, 24);
			this.dpMainPanel.Name = "dpMainPanel";
			this.dpMainPanel.Size = new System.Drawing.Size(1041, 524);
			this.dpMainPanel.TabIndex = 0;
			this.dpMainPanel.ContentAdded += new System.EventHandler<WeifenLuo.WinFormsUI.Docking.DockContentEventArgs>(this.dpMainPanel_ContentAdded);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.viewToolStripMenuItem,
            this.tsmiHelp});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1041, 24);
			this.menuStrip.TabIndex = 1;
			this.menuStrip.Text = "menuStrip1";
			// 
			// tsmiFile
			// 
			this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReloadPlugins,
            this.tsmiSelectGame,
            this.tsmiPreferences});
			this.tsmiFile.Name = "tsmiFile";
			this.tsmiFile.Size = new System.Drawing.Size(37, 20);
			this.tsmiFile.Text = "File";
			this.tsmiFile.MouseHover += new System.EventHandler(this.tsmi_Hover);
			// 
			// tsmiSelectGame
			// 
			this.tsmiSelectGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.falloutNewVegasToolStripMenuItem,
            this.fallout4ToolStripMenuItem});
			this.tsmiSelectGame.Name = "tsmiSelectGame";
			this.tsmiSelectGame.Size = new System.Drawing.Size(179, 22);
			this.tsmiSelectGame.Text = "Select Game";
			// 
			// falloutNewVegasToolStripMenuItem
			// 
			this.falloutNewVegasToolStripMenuItem.CheckOnClick = true;
			this.falloutNewVegasToolStripMenuItem.Name = "falloutNewVegasToolStripMenuItem";
			this.falloutNewVegasToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.falloutNewVegasToolStripMenuItem.Text = "Fallout: New Vegas";
			// 
			// fallout4ToolStripMenuItem
			// 
			this.fallout4ToolStripMenuItem.CheckOnClick = true;
			this.fallout4ToolStripMenuItem.Name = "fallout4ToolStripMenuItem";
			this.fallout4ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.fallout4ToolStripMenuItem.Text = "Fallout 4";
			// 
			// tsmiPreferences
			// 
			this.tsmiPreferences.Name = "tsmiPreferences";
			this.tsmiPreferences.Size = new System.Drawing.Size(179, 22);
			this.tsmiPreferences.Text = "PreferencesWindow";
			this.tsmiPreferences.Click += new System.EventHandler(this.tsmiPreferences_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActivePanels,
            this.tsmiPanels});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			this.viewToolStripMenuItem.MouseHover += new System.EventHandler(this.tsmi_Hover);
			// 
			// tsmiActivePanels
			// 
			this.tsmiActivePanels.Name = "tsmiActivePanels";
			this.tsmiActivePanels.Size = new System.Drawing.Size(144, 22);
			this.tsmiActivePanels.Text = "Active Panels";
			// 
			// tsmiPanels
			// 
			this.tsmiPanels.Name = "tsmiPanels";
			this.tsmiPanels.Size = new System.Drawing.Size(144, 22);
			this.tsmiPanels.Text = "Panels";
			// 
			// tsmiHelp
			// 
			this.tsmiHelp.Name = "tsmiHelp";
			this.tsmiHelp.Size = new System.Drawing.Size(44, 20);
			this.tsmiHelp.Text = "Help";
			this.tsmiHelp.MouseHover += new System.EventHandler(this.tsmi_Hover);
			// 
			// tsmiReloadPlugins
			// 
			this.tsmiReloadPlugins.Name = "tsmiReloadPlugins";
			this.tsmiReloadPlugins.Size = new System.Drawing.Size(179, 22);
			this.tsmiReloadPlugins.Text = "Reload Plugins";
			this.tsmiReloadPlugins.Click += new System.EventHandler(this.tsmiReloadPlugins_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1041, 548);
			this.Controls.Add(this.dpMainPanel);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainWindow";
			this.Text = "MainWindow";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private WeifenLuo.WinFormsUI.Docking.DockPanel dpMainPanel;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem tsmiFile;
		private System.Windows.Forms.ToolStripMenuItem tsmiPreferences;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiActivePanels;
		private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
		private System.Windows.Forms.ToolStripMenuItem tsmiSelectGame;
		private System.Windows.Forms.ToolStripMenuItem falloutNewVegasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fallout4ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiPanels;
		private System.Windows.Forms.ToolStripMenuItem tsmiReloadPlugins;
	}
}

