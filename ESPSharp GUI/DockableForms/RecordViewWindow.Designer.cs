namespace ESPSharp_GUI.DockableForms
{
	partial class RecordViewWindow
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.treeListView1 = new BrightIdeasSoftware.TreeListView();
			this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Window;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(3, 3);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(334, 374);
			this.textBox1.TabIndex = 0;
			// 
			// treeListView1
			// 
			this.treeListView1.AllColumns.Add(this.olvColumn1);
			this.treeListView1.AllColumns.Add(this.olvColumn2);
			this.treeListView1.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
			this.treeListView1.CellEditUseWholeCell = false;
			this.treeListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
			this.treeListView1.Cursor = System.Windows.Forms.Cursors.Default;
			this.treeListView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeListView1.HighlightBackgroundColor = System.Drawing.Color.Empty;
			this.treeListView1.HighlightForegroundColor = System.Drawing.Color.Empty;
			this.treeListView1.IsSimpleDragSource = true;
			this.treeListView1.IsSimpleDropSink = true;
			this.treeListView1.Location = new System.Drawing.Point(0, 0);
			this.treeListView1.Name = "treeListView1";
			this.treeListView1.ShowFilterMenuOnRightClick = false;
			this.treeListView1.ShowGroups = false;
			this.treeListView1.Size = new System.Drawing.Size(280, 374);
			this.treeListView1.TabIndex = 1;
			this.treeListView1.UseCompatibleStateImageBehavior = false;
			this.treeListView1.UseTranslucentSelection = true;
			this.treeListView1.View = System.Windows.Forms.View.Details;
			this.treeListView1.VirtualMode = true;
			this.treeListView1.Expanding += new System.EventHandler<BrightIdeasSoftware.TreeBranchExpandingEventArgs>(this.treeListView1_Expanding);
			// 
			// olvColumn1
			// 
			this.olvColumn1.AspectName = "Name";
			this.olvColumn1.IsEditable = false;
			this.olvColumn1.Sortable = false;
			this.olvColumn1.Text = "Data";
			this.olvColumn1.Width = 150;
			// 
			// olvColumn2
			// 
			this.olvColumn2.AspectName = "Value";
			this.olvColumn2.CellEditUseWholeCell = true;
			this.olvColumn2.Groupable = false;
			this.olvColumn2.Sortable = false;
			this.olvColumn2.Text = "Value";
			this.olvColumn2.Width = 200;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1022, 380);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(343, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeListView1);
			this.splitContainer1.Size = new System.Drawing.Size(676, 374);
			this.splitContainer1.SplitterDistance = 280;
			this.splitContainer1.TabIndex = 3;
			// 
			// RecordViewWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1022, 380);
			this.CloseButton = false;
			this.CloseButtonVisible = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HideOnClose = true;
			this.Name = "RecordViewWindow";
			this.Text = "Records";
			((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private BrightIdeasSoftware.TreeListView treeListView1;
		private BrightIdeasSoftware.OLVColumn olvColumn1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private BrightIdeasSoftware.OLVColumn olvColumn2;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}