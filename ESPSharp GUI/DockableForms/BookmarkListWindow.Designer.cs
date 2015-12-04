﻿namespace ESPSharp_GUI.DockableForms
{
	partial class BookmarkListWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookmarkListWindow));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.treeListView1 = new BrightIdeasSoftware.TreeListView();
			this.olvcFormID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvcEditorID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvcName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.btbFilter = new ESPSharp_GUI.Controls.ButtonTextBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.treeListView1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btbFilter, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnClear, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.button2, 3, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 262);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Search";
			// 
			// treeListView1
			// 
			this.treeListView1.AllColumns.Add(this.olvcFormID);
			this.treeListView1.AllColumns.Add(this.olvcEditorID);
			this.treeListView1.AllColumns.Add(this.olvcName);
			this.treeListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvcFormID,
            this.olvcEditorID,
            this.olvcName});
			this.tableLayoutPanel1.SetColumnSpan(this.treeListView1, 4);
			this.treeListView1.Cursor = System.Windows.Forms.Cursors.Default;
			this.treeListView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeListView1.FullRowSelect = true;
			this.treeListView1.IsSimpleDragSource = true;
			this.treeListView1.IsSimpleDropSink = true;
			this.treeListView1.Location = new System.Drawing.Point(3, 28);
			this.treeListView1.Name = "treeListView1";
			this.treeListView1.OwnerDraw = true;
			this.treeListView1.ShowFilterMenuOnRightClick = false;
			this.treeListView1.ShowGroups = false;
			this.treeListView1.Size = new System.Drawing.Size(528, 231);
			this.treeListView1.TabIndex = 3;
			this.treeListView1.UseCompatibleStateImageBehavior = false;
			this.treeListView1.View = System.Windows.Forms.View.Details;
			this.treeListView1.VirtualMode = true;
			this.treeListView1.Expanding += new System.EventHandler<BrightIdeasSoftware.TreeBranchExpandingEventArgs>(this.tlvPluginList_Expanding);
			this.treeListView1.Collapsing += new System.EventHandler<BrightIdeasSoftware.TreeBranchCollapsingEventArgs>(this.tlvPluginsList_Collapsing);
			this.treeListView1.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.tlvPluginList_CellClick);
			// 
			// olvcFormID
			// 
			this.olvcFormID.CellPadding = null;
			this.olvcFormID.Groupable = false;
			this.olvcFormID.Hideable = false;
			this.olvcFormID.Text = "FormID";
			this.olvcFormID.Width = 150;
			// 
			// olvcEditorID
			// 
			this.olvcEditorID.CellPadding = null;
			this.olvcEditorID.Groupable = false;
			this.olvcEditorID.Hideable = false;
			this.olvcEditorID.Text = "EditorID";
			this.olvcEditorID.Width = 150;
			// 
			// olvcName
			// 
			this.olvcName.CellPadding = null;
			this.olvcName.FillsFreeSpace = true;
			this.olvcName.Groupable = false;
			this.olvcName.Hideable = false;
			this.olvcName.Text = "Name";
			this.olvcName.Width = 150;
			// 
			// btbFilter
			// 
			this.btbFilter.ButtonWidth = 0;
			this.btbFilter.ContentsImage = null;
			this.btbFilter.DefaultImage = null;
			this.btbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btbFilter.EmptyImage = null;
			this.btbFilter.Location = new System.Drawing.Point(50, 3);
			this.btbFilter.Name = "btbFilter";
			this.btbFilter.Size = new System.Drawing.Size(411, 20);
			this.btbFilter.TabIndex = 4;
			this.btbFilter.TextChanged += new System.EventHandler(this.btbFilter_TextChanged);
			// 
			// btnClear
			// 
			this.btnClear.FlatAppearance.BorderSize = 0;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Image = global::ESPSharp_GUI.Properties.Resources.cross_button;
			this.btnClear.Location = new System.Drawing.Point(467, 3);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(29, 19);
			this.btnClear.TabIndex = 5;
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(502, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(29, 19);
			this.button2.TabIndex = 6;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// BookmarkListWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 262);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BookmarkListWindow";
			this.Text = "Bookmarks";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private BrightIdeasSoftware.TreeListView treeListView1;
		private BrightIdeasSoftware.OLVColumn olvcFormID;
		private BrightIdeasSoftware.OLVColumn olvcEditorID;
		private BrightIdeasSoftware.OLVColumn olvcName;
		private Controls.ButtonTextBox btbFilter;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button button2;
	}
}