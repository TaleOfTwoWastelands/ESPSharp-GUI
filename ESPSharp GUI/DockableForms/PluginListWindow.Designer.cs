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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.tlvPluginList = new BrightIdeasSoftware.TreeListView();
			this.olvcFormID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvcEditorID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvcName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.btbFilter = new ESPSharp_GUI.Controls.ButtonTextBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tlvPluginList)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tlvPluginList, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btbFilter, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 262);
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
			// tlvPluginList
			// 
			this.tlvPluginList.AllColumns.Add(this.olvcFormID);
			this.tlvPluginList.AllColumns.Add(this.olvcEditorID);
			this.tlvPluginList.AllColumns.Add(this.olvcName);
			this.tlvPluginList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvcFormID,
            this.olvcEditorID,
            this.olvcName});
			this.tableLayoutPanel1.SetColumnSpan(this.tlvPluginList, 2);
			this.tlvPluginList.Cursor = System.Windows.Forms.Cursors.Default;
			this.tlvPluginList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlvPluginList.FullRowSelect = true;
			this.tlvPluginList.IsSimpleDragSource = true;
			this.tlvPluginList.Location = new System.Drawing.Point(3, 29);
			this.tlvPluginList.Name = "tlvPluginList";
			this.tlvPluginList.OwnerDraw = true;
			this.tlvPluginList.ShowFilterMenuOnRightClick = false;
			this.tlvPluginList.ShowGroups = false;
			this.tlvPluginList.Size = new System.Drawing.Size(496, 230);
			this.tlvPluginList.TabIndex = 3;
			this.tlvPluginList.UseCompatibleStateImageBehavior = false;
			this.tlvPluginList.View = System.Windows.Forms.View.Details;
			this.tlvPluginList.VirtualMode = true;
			this.tlvPluginList.Expanding += new System.EventHandler<BrightIdeasSoftware.TreeBranchExpandingEventArgs>(this.tlvPluginList_Expanding);
			this.tlvPluginList.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.tlvPluginList_CellClick);
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
			this.btbFilter.ButtonWidth = 25;
			this.btbFilter.ContentsImage = global::ESPSharp_GUI.Properties.Resources.cross_button;
			this.btbFilter.DefaultImage = global::ESPSharp_GUI.Properties.Resources.magnifier_left;
			this.btbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btbFilter.EmptyImage = global::ESPSharp_GUI.Properties.Resources.magnifier_left;
			this.btbFilter.Location = new System.Drawing.Point(50, 3);
			this.btbFilter.Name = "btbFilter";
			this.btbFilter.Size = new System.Drawing.Size(449, 20);
			this.btbFilter.TabIndex = 4;
			this.btbFilter.TextChanged += new System.EventHandler(this.btbFilter_TextChanged);
			// 
			// PluginListWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 262);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "PluginListWindow";
			this.Text = "PluginListWindow";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tlvPluginList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private BrightIdeasSoftware.TreeListView tlvPluginList;
		private BrightIdeasSoftware.OLVColumn olvcFormID;
		private BrightIdeasSoftware.OLVColumn olvcEditorID;
		private BrightIdeasSoftware.OLVColumn olvcName;
		private Controls.ButtonTextBox btbFilter;
	}
}