namespace ESPSharp_GUI.Controls
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiReloadPlugins = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSelectGame = new System.Windows.Forms.ToolStripMenuItem();
			this.falloutNewVegasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fallout4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPreferences = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.dpMainPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.vS2003Theme1 = new WeifenLuo.WinFormsUI.Docking.VS2003Theme();
			this.vS2005Theme1 = new WeifenLuo.WinFormsUI.Docking.VS2005Theme();
			this.vS2012LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2012LightTheme();
			this.vS2013BlueTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2013BlueTheme();
			this.tableLayoutPanel1.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.menuStrip, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.dpMainPanel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(736, 534);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// menuStrip
			// 
			this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.viewToolStripMenuItem,
            this.tsmiHelp});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.MdiWindowListItem = this.viewToolStripMenuItem;
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(736, 30);
			this.menuStrip.TabIndex = 5;
			this.menuStrip.Text = "menuStrip1";
			// 
			// tsmiFile
			// 
			this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReloadPlugins,
            this.tsmiSelectGame,
            this.tsmiPreferences});
			this.tsmiFile.Name = "tsmiFile";
			this.tsmiFile.Size = new System.Drawing.Size(37, 26);
			this.tsmiFile.Text = "&File";
			this.tsmiFile.MouseHover += new System.EventHandler(this.tsmi_Hover);
			// 
			// tsmiReloadPlugins
			// 
			this.tsmiReloadPlugins.Name = "tsmiReloadPlugins";
			this.tsmiReloadPlugins.Size = new System.Drawing.Size(179, 22);
			this.tsmiReloadPlugins.Text = "Reload Plugins";
			this.tsmiReloadPlugins.Click += new System.EventHandler(this.tsmiReloadPlugins_Click);
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
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 26);
			this.viewToolStripMenuItem.Text = "&View";
			this.viewToolStripMenuItem.MouseHover += new System.EventHandler(this.tsmi_Hover);
			// 
			// tsmiHelp
			// 
			this.tsmiHelp.Name = "tsmiHelp";
			this.tsmiHelp.Size = new System.Drawing.Size(44, 26);
			this.tsmiHelp.Text = "Help";
			this.tsmiHelp.Click += new System.EventHandler(this.tsmiHelp_Click);
			this.tsmiHelp.MouseHover += new System.EventHandler(this.tsmi_Hover);
			// 
			// dpMainPanel
			// 
			this.dpMainPanel.BackColor = System.Drawing.SystemColors.ControlDark;
			this.dpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dpMainPanel.DockBottomPortion = 0.2D;
			this.dpMainPanel.DockLeftPortion = 0.3D;
			this.dpMainPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
			this.dpMainPanel.Location = new System.Drawing.Point(0, 30);
			this.dpMainPanel.Margin = new System.Windows.Forms.Padding(0);
			this.dpMainPanel.Name = "dpMainPanel";
			this.dpMainPanel.ShowDocumentIcon = true;
			this.dpMainPanel.Size = new System.Drawing.Size(736, 482);
			this.dpMainPanel.TabIndex = 0;
			this.dpMainPanel.Theme = this.vS2005Theme1;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
			this.statusStrip1.Location = new System.Drawing.Point(0, 512);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(736, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(367, 17);
			this.toolStripStatusLabel2.Spring = true;
			this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MainWindow";
			this.Size = new System.Drawing.Size(736, 534);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private WeifenLuo.WinFormsUI.Docking.DockPanel dpMainPanel;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem tsmiFile;
		private System.Windows.Forms.ToolStripMenuItem tsmiReloadPlugins;
		private System.Windows.Forms.ToolStripMenuItem tsmiSelectGame;
		private System.Windows.Forms.ToolStripMenuItem falloutNewVegasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fallout4ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiPreferences;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
		private WeifenLuo.WinFormsUI.Docking.VS2003Theme vS2003Theme1;
		private WeifenLuo.WinFormsUI.Docking.VS2005Theme vS2005Theme1;
		private WeifenLuo.WinFormsUI.Docking.VS2012LightTheme vS2012LightTheme1;
		private WeifenLuo.WinFormsUI.Docking.VS2013BlueTheme vS2013BlueTheme1;
	}
}
