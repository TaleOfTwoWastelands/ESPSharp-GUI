namespace ESPSharp_GUI.Controls
{
	partial class PluginTreeView
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginTreeView));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.btbFilter = new ESPSharp_GUI.Controls.ButtonTextBox();
			this.tlvPluginList = new BrightIdeasSoftware.TreeListView();
			this.olvcFormID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvcEditorID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvcName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tlvPluginList)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ContextMenuStrip = this.contextMenuStrip;
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btbFilter, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.tlvPluginList, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(508, 353);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(153, 26);
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
			// btbFilter
			// 
			this.btbFilter.ButtonWidth = 25;
			this.btbFilter.ContentsImage = ((System.Drawing.Image)(resources.GetObject("btbFilter.ContentsImage")));
			this.btbFilter.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btbFilter.DefaultImage")));
			this.btbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btbFilter.EmptyImage = ((System.Drawing.Image)(resources.GetObject("btbFilter.EmptyImage")));
			this.btbFilter.Location = new System.Drawing.Point(50, 3);
			this.btbFilter.Name = "btbFilter";
			this.btbFilter.PromptFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btbFilter.PromptForeColor = System.Drawing.SystemColors.GrayText;
			this.btbFilter.PromptText = "Enter load order FormID or EditorID";
			this.btbFilter.Size = new System.Drawing.Size(455, 20);
			this.btbFilter.TabIndex = 4;
			this.btbFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btbFilter_KeyDown);
			// 
			// tlvPluginList
			// 
			this.tlvPluginList.AllColumns.Add(this.olvcFormID);
			this.tlvPluginList.AllColumns.Add(this.olvcEditorID);
			this.tlvPluginList.AllColumns.Add(this.olvcName);
			this.tlvPluginList.CellEditUseWholeCell = false;
			this.tlvPluginList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvcFormID,
            this.olvcEditorID,
            this.olvcName});
			this.tableLayoutPanel1.SetColumnSpan(this.tlvPluginList, 2);
			this.tlvPluginList.Cursor = System.Windows.Forms.Cursors.Default;
			this.tlvPluginList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlvPluginList.FullRowSelect = true;
			this.tlvPluginList.HideSelection = false;
			this.tlvPluginList.HighlightBackgroundColor = System.Drawing.Color.Empty;
			this.tlvPluginList.HighlightForegroundColor = System.Drawing.Color.Empty;
			this.tlvPluginList.IsSimpleDragSource = true;
			this.tlvPluginList.Location = new System.Drawing.Point(3, 29);
			this.tlvPluginList.Name = "tlvPluginList";
			this.tlvPluginList.RevealAfterExpand = false;
			this.tlvPluginList.ShowFilterMenuOnRightClick = false;
			this.tlvPluginList.ShowGroups = false;
			this.tlvPluginList.ShowItemToolTips = true;
			this.tlvPluginList.Size = new System.Drawing.Size(502, 321);
			this.tlvPluginList.TabIndex = 5;
			this.tlvPluginList.UseAlternatingBackColors = true;
			this.tlvPluginList.UseCompatibleStateImageBehavior = false;
			this.tlvPluginList.UseHotControls = false;
			this.tlvPluginList.UseHotItem = true;
			this.tlvPluginList.UseTranslucentHotItem = true;
			this.tlvPluginList.View = System.Windows.Forms.View.Details;
			this.tlvPluginList.VirtualMode = true;
			this.tlvPluginList.Expanding += new System.EventHandler<BrightIdeasSoftware.TreeBranchExpandingEventArgs>(this.tlvPluginList_Expanding);
			this.tlvPluginList.Collapsing += new System.EventHandler<BrightIdeasSoftware.TreeBranchCollapsingEventArgs>(this.tlvPluginsList_Collapsing);
			// 
			// olvcFormID
			// 
			this.olvcFormID.Groupable = false;
			this.olvcFormID.Hideable = false;
			this.olvcFormID.IsEditable = false;
			this.olvcFormID.Text = "FormID";
			this.olvcFormID.Width = 120;
			// 
			// olvcEditorID
			// 
			this.olvcEditorID.Groupable = false;
			this.olvcEditorID.Hideable = false;
			this.olvcEditorID.IsEditable = false;
			this.olvcEditorID.Text = "EditorID";
			this.olvcEditorID.Width = 120;
			// 
			// olvcName
			// 
			this.olvcName.Groupable = false;
			this.olvcName.Hideable = false;
			this.olvcName.IsEditable = false;
			this.olvcName.Text = "Name";
			this.olvcName.Width = 150;
			// 
			// PluginTreeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "PluginTreeView";
			this.Size = new System.Drawing.Size(508, 353);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tlvPluginList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private ButtonTextBox btbFilter;
		private BrightIdeasSoftware.TreeListView tlvPluginList;
		private BrightIdeasSoftware.OLVColumn olvcFormID;
		private BrightIdeasSoftware.OLVColumn olvcEditorID;
		private BrightIdeasSoftware.OLVColumn olvcName;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
	}
}
