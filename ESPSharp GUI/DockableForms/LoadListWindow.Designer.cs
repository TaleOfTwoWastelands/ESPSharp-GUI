namespace ESPSharp_GUI
{
	partial class LoadListWindow
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
			this.lvPluginList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmsLoadPluginsList = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiCmsSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCmsSelectNone = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCmsSelectInvert = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonOK = new System.Windows.Forms.Button();
			this.cmsLoadPluginsList.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvPluginList
			// 
			this.lvPluginList.CheckBoxes = true;
			this.lvPluginList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.lvPluginList.ContextMenuStrip = this.cmsLoadPluginsList;
			this.lvPluginList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvPluginList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lvPluginList.Location = new System.Drawing.Point(3, 3);
			this.lvPluginList.Name = "lvPluginList";
			this.lvPluginList.Size = new System.Drawing.Size(350, 293);
			this.lvPluginList.TabIndex = 0;
			this.lvPluginList.UseCompatibleStateImageBehavior = false;
			this.lvPluginList.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "";
			this.columnHeader1.Width = 300;
			// 
			// cmsLoadPluginsList
			// 
			this.cmsLoadPluginsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCmsSelectAll,
            this.tsmiCmsSelectNone,
            this.tsmiCmsSelectInvert});
			this.cmsLoadPluginsList.Name = "cmsLoadPluginsList";
			this.cmsLoadPluginsList.Size = new System.Drawing.Size(156, 70);
			// 
			// tsmiCmsSelectAll
			// 
			this.tsmiCmsSelectAll.Name = "tsmiCmsSelectAll";
			this.tsmiCmsSelectAll.Size = new System.Drawing.Size(155, 22);
			this.tsmiCmsSelectAll.Text = "Select All";
			this.tsmiCmsSelectAll.Click += new System.EventHandler(this.tsmiCmsSelectAll_Click);
			// 
			// tsmiCmsSelectNone
			// 
			this.tsmiCmsSelectNone.Name = "tsmiCmsSelectNone";
			this.tsmiCmsSelectNone.Size = new System.Drawing.Size(155, 22);
			this.tsmiCmsSelectNone.Text = "Select None";
			this.tsmiCmsSelectNone.Click += new System.EventHandler(this.tsmiCmsSelectNone_Click);
			// 
			// tsmiCmsSelectInvert
			// 
			this.tsmiCmsSelectInvert.Name = "tsmiCmsSelectInvert";
			this.tsmiCmsSelectInvert.Size = new System.Drawing.Size(155, 22);
			this.tsmiCmsSelectInvert.Text = "Invert Selection";
			this.tsmiCmsSelectInvert.Click += new System.EventHandler(this.tsmiCmsSelectInvert_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.lvPluginList, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonOK, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 329);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonOK.Location = new System.Drawing.Point(140, 302);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// LoadListWindow
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 329);
			this.CloseButton = false;
			this.CloseButtonVisible = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HideOnClose = true;
			this.Name = "LoadListWindow";
			this.Text = "Select plugins to load";
			this.cmsLoadPluginsList.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvPluginList;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.ContextMenuStrip cmsLoadPluginsList;
		private System.Windows.Forms.ToolStripMenuItem tsmiCmsSelectAll;
		private System.Windows.Forms.ToolStripMenuItem tsmiCmsSelectNone;
		private System.Windows.Forms.ToolStripMenuItem tsmiCmsSelectInvert;
	}
}