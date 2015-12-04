namespace ESPSharp_GUI.DockableForms
{
	partial class PreferencesWindow
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.PrefGbxPaths = new System.Windows.Forms.GroupBox();
			this.PredDgvBtnRemove = new System.Windows.Forms.Button();
			this.PrefDgvBtnAdd = new System.Windows.Forms.Button();
			this.PrefDgvLocations = new System.Windows.Forms.DataGridView();
			this.ColumnGameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnRecursive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ColumnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrefGbx2 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.PrefBtnApply = new System.Windows.Forms.Button();
			this.PropTlpContainer = new System.Windows.Forms.TableLayoutPanel();
			this.PrefToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.PrefGbxPaths.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PrefDgvLocations)).BeginInit();
			this.panel1.SuspendLayout();
			this.PropTlpContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// PrefGbxPaths
			// 
			this.PrefGbxPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PrefGbxPaths.Controls.Add(this.PredDgvBtnRemove);
			this.PrefGbxPaths.Controls.Add(this.PrefDgvBtnAdd);
			this.PrefGbxPaths.Controls.Add(this.PrefDgvLocations);
			this.PrefGbxPaths.Location = new System.Drawing.Point(14, 14);
			this.PrefGbxPaths.Margin = new System.Windows.Forms.Padding(5);
			this.PrefGbxPaths.Name = "PrefGbxPaths";
			this.PrefGbxPaths.Size = new System.Drawing.Size(666, 195);
			this.PrefGbxPaths.TabIndex = 0;
			this.PrefGbxPaths.TabStop = false;
			this.PrefGbxPaths.Text = "Plugins Locations";
			// 
			// PredDgvBtnRemove
			// 
			this.PredDgvBtnRemove.Location = new System.Drawing.Point(87, 166);
			this.PredDgvBtnRemove.Name = "PredDgvBtnRemove";
			this.PredDgvBtnRemove.Size = new System.Drawing.Size(75, 23);
			this.PredDgvBtnRemove.TabIndex = 3;
			this.PredDgvBtnRemove.Text = "Remove";
			this.PrefToolTip.SetToolTip(this.PredDgvBtnRemove, "Select a row header to remove a row.");
			this.PredDgvBtnRemove.UseVisualStyleBackColor = true;
			this.PredDgvBtnRemove.Click += new System.EventHandler(this.DgvButtonRemove_Click);
			// 
			// PrefDgvBtnAdd
			// 
			this.PrefDgvBtnAdd.Location = new System.Drawing.Point(6, 166);
			this.PrefDgvBtnAdd.Name = "PrefDgvBtnAdd";
			this.PrefDgvBtnAdd.Size = new System.Drawing.Size(75, 23);
			this.PrefDgvBtnAdd.TabIndex = 2;
			this.PrefDgvBtnAdd.Text = "Add";
			this.PrefToolTip.SetToolTip(this.PrefDgvBtnAdd, "Add a new row.");
			this.PrefDgvBtnAdd.UseVisualStyleBackColor = true;
			this.PrefDgvBtnAdd.Click += new System.EventHandler(this.DgvButtonAdd_Click);
			// 
			// PrefDgvLocations
			// 
			this.PrefDgvLocations.AllowUserToAddRows = false;
			this.PrefDgvLocations.AllowUserToResizeColumns = false;
			this.PrefDgvLocations.AllowUserToResizeRows = false;
			this.PrefDgvLocations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.PrefDgvLocations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.PrefDgvLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PrefDgvLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnGameName,
            this.ColumnRecursive,
            this.ColumnPath});
			this.PrefDgvLocations.Location = new System.Drawing.Point(6, 19);
			this.PrefDgvLocations.Name = "PrefDgvLocations";
			this.PrefDgvLocations.Size = new System.Drawing.Size(654, 141);
			this.PrefDgvLocations.TabIndex = 1;
			this.PrefDgvLocations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrefDgvLocations_CellClick);
			// 
			// ColumnGameName
			// 
			this.ColumnGameName.HeaderText = "Game";
			this.ColumnGameName.MinimumWidth = 120;
			this.ColumnGameName.Name = "ColumnGameName";
			this.ColumnGameName.ToolTipText = "The name of the game a path applies to.";
			this.ColumnGameName.Width = 120;
			// 
			// ColumnRecursive
			// 
			this.ColumnRecursive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ColumnRecursive.HeaderText = "Recursive";
			this.ColumnRecursive.Name = "ColumnRecursive";
			this.ColumnRecursive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColumnRecursive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.ColumnRecursive.ToolTipText = "Should the folder be checked recursively for plugins.";
			this.ColumnRecursive.Width = 80;
			// 
			// ColumnPath
			// 
			this.ColumnPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColumnPath.HeaderText = "Path";
			this.ColumnPath.MinimumWidth = 100;
			this.ColumnPath.Name = "ColumnPath";
			// 
			// PrefGbx2
			// 
			this.PrefGbx2.Location = new System.Drawing.Point(14, 219);
			this.PrefGbx2.Margin = new System.Windows.Forms.Padding(5);
			this.PrefGbx2.Name = "PrefGbx2";
			this.PrefGbx2.Size = new System.Drawing.Size(202, 96);
			this.PrefGbx2.TabIndex = 1;
			this.PrefGbx2.TabStop = false;
			this.PrefGbx2.Text = "Visual Style";
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.PrefGbx2);
			this.panel1.Controls.Add(this.PrefGbxPaths);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(694, 429);
			this.panel1.TabIndex = 2;
			// 
			// PrefBtnApply
			// 
			this.PrefBtnApply.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PrefBtnApply.Location = new System.Drawing.Point(312, 438);
			this.PrefBtnApply.MinimumSize = new System.Drawing.Size(75, 23);
			this.PrefBtnApply.Name = "PrefBtnApply";
			this.PrefBtnApply.Size = new System.Drawing.Size(75, 23);
			this.PrefBtnApply.TabIndex = 3;
			this.PrefBtnApply.Text = "Apply";
			this.PrefBtnApply.UseVisualStyleBackColor = true;
			this.PrefBtnApply.Click += new System.EventHandler(this.PrefBtnApply_Click);
			// 
			// PropTlpContainer
			// 
			this.PropTlpContainer.ColumnCount = 1;
			this.PropTlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.PropTlpContainer.Controls.Add(this.PrefBtnApply, 0, 1);
			this.PropTlpContainer.Controls.Add(this.panel1, 0, 0);
			this.PropTlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PropTlpContainer.Location = new System.Drawing.Point(0, 0);
			this.PropTlpContainer.Margin = new System.Windows.Forms.Padding(0);
			this.PropTlpContainer.Name = "PropTlpContainer";
			this.PropTlpContainer.RowCount = 2;
			this.PropTlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.PropTlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.PropTlpContainer.Size = new System.Drawing.Size(700, 465);
			this.PropTlpContainer.TabIndex = 3;
			// 
			// PreferencesWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 465);
			this.Controls.Add(this.PropTlpContainer);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HideOnClose = true;
			this.Name = "PreferencesWindow";
			this.Text = "Preferences";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Preferences_FormClosing);
			this.Load += new System.EventHandler(this.Preferences_Load);
			this.PrefGbxPaths.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PrefDgvLocations)).EndInit();
			this.panel1.ResumeLayout(false);
			this.PropTlpContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox PrefGbxPaths;
		private System.Windows.Forms.DataGridView PrefDgvLocations;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameName;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnRecursive;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPath;
		private System.Windows.Forms.GroupBox PrefGbx2;
		private System.Windows.Forms.Button PredDgvBtnRemove;
		private System.Windows.Forms.Button PrefDgvBtnAdd;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button PrefBtnApply;
		private System.Windows.Forms.TableLayoutPanel PropTlpContainer;
		private System.Windows.Forms.ToolTip PrefToolTip;
	}
}