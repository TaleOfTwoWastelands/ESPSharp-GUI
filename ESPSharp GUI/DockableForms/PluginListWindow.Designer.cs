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
			this.components = new System.ComponentModel.Container();
			this.cmsCellRightClickPlugin = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsCellRightClickRecord = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newPluginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.copyToBookmarksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsCellRightClickGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newPluginToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.copyToBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pluginTreeView = new ESPSharp_GUI.Controls.PluginTreeView();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.copyAsOverrideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deepCopyAsNewRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsCellRightClickPlugin.SuspendLayout();
			this.cmsCellRightClickRecord.SuspendLayout();
			this.cmsCellRightClickGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmsCellRightClickPlugin
			// 
			this.cmsCellRightClickPlugin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPluginToolStripMenuItem});
			this.cmsCellRightClickPlugin.Name = "cmsCellRightClickPlugin";
			this.cmsCellRightClickPlugin.Size = new System.Drawing.Size(136, 26);
			// 
			// newPluginToolStripMenuItem
			// 
			this.newPluginToolStripMenuItem.Name = "newPluginToolStripMenuItem";
			this.newPluginToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.newPluginToolStripMenuItem.Text = "New Plugin";
			// 
			// cmsCellRightClickRecord
			// 
			this.cmsCellRightClickRecord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPluginToolStripMenuItem1,
            this.toolStripSeparator2,
            this.copyToBookmarksToolStripMenuItem1,
            this.toolStripSeparator4,
            this.copyAsOverrideToolStripMenuItem,
            this.deepCopyAsNewRecordToolStripMenuItem});
			this.cmsCellRightClickRecord.Name = "cmsCellRightClickPlugin";
			this.cmsCellRightClickRecord.Size = new System.Drawing.Size(179, 126);
			// 
			// newPluginToolStripMenuItem1
			// 
			this.newPluginToolStripMenuItem1.Name = "newPluginToolStripMenuItem1";
			this.newPluginToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
			this.newPluginToolStripMenuItem1.Text = "New Plugin";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
			// 
			// copyToBookmarksToolStripMenuItem1
			// 
			this.copyToBookmarksToolStripMenuItem1.Name = "copyToBookmarksToolStripMenuItem1";
			this.copyToBookmarksToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
			this.copyToBookmarksToolStripMenuItem1.Text = "Copy to Bookmarks";
			this.copyToBookmarksToolStripMenuItem1.Click += new System.EventHandler(this.copyToBookmarksToolStripMenuItem_Click);
			// 
			// cmsCellRightClickGroup
			// 
			this.cmsCellRightClickGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPluginToolStripMenuItem2,
            this.toolStripSeparator1,
            this.copyToBookmarksToolStripMenuItem,
            this.toolStripSeparator3});
			this.cmsCellRightClickGroup.Name = "cmsCellRightClickPlugin";
			this.cmsCellRightClickGroup.Size = new System.Drawing.Size(179, 60);
			// 
			// newPluginToolStripMenuItem2
			// 
			this.newPluginToolStripMenuItem2.Name = "newPluginToolStripMenuItem2";
			this.newPluginToolStripMenuItem2.Size = new System.Drawing.Size(178, 22);
			this.newPluginToolStripMenuItem2.Text = "New Plugin";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
			// 
			// copyToBookmarksToolStripMenuItem
			// 
			this.copyToBookmarksToolStripMenuItem.Name = "copyToBookmarksToolStripMenuItem";
			this.copyToBookmarksToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.copyToBookmarksToolStripMenuItem.Text = "Copy to Bookmarks";
			this.copyToBookmarksToolStripMenuItem.Click += new System.EventHandler(this.copyToBookmarksToolStripMenuItem_Click);
			// 
			// pluginTreeView
			// 
			this.pluginTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pluginTreeView.Location = new System.Drawing.Point(0, 0);
			this.pluginTreeView.Name = "pluginTreeView";
			this.pluginTreeView.Size = new System.Drawing.Size(502, 262);
			this.pluginTreeView.TabIndex = 0;
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(175, 6);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(175, 6);
			// 
			// copyAsOverrideToolStripMenuItem
			// 
			this.copyAsOverrideToolStripMenuItem.Name = "copyAsOverrideToolStripMenuItem";
			this.copyAsOverrideToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.copyAsOverrideToolStripMenuItem.Text = "Copy as override";
			this.copyAsOverrideToolStripMenuItem.Click += new System.EventHandler(this.copyAsOverrideToolStripMenuItem_Click);
			// 
			// deepCopyAsNewRecordToolStripMenuItem
			// 
			this.deepCopyAsNewRecordToolStripMenuItem.Name = "deepCopyAsNewRecordToolStripMenuItem";
			this.deepCopyAsNewRecordToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.deepCopyAsNewRecordToolStripMenuItem.Text = "Copy as new record";
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
			this.cmsCellRightClickPlugin.ResumeLayout(false);
			this.cmsCellRightClickRecord.ResumeLayout(false);
			this.cmsCellRightClickGroup.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.PluginTreeView pluginTreeView;
		private System.Windows.Forms.ContextMenuStrip cmsCellRightClickPlugin;
		private System.Windows.Forms.ContextMenuStrip cmsCellRightClickRecord;
		private System.Windows.Forms.ContextMenuStrip cmsCellRightClickGroup;
		private System.Windows.Forms.ToolStripMenuItem newPluginToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newPluginToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem newPluginToolStripMenuItem2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem copyToBookmarksToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem copyToBookmarksToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem copyAsOverrideToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deepCopyAsNewRecordToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
	}
}