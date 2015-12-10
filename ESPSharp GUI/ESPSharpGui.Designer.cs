namespace ESPSharp_GUI
{
	partial class EspSharpGui
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
			this.mainWindow1 = new ESPSharp_GUI.Controls.MainWindow();
			this.SuspendLayout();
			// 
			// mainWindow1
			// 
			this.mainWindow1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainWindow1.Location = new System.Drawing.Point(0, 0);
			this.mainWindow1.Name = "mainWindow1";
			this.mainWindow1.Size = new System.Drawing.Size(1021, 548);
			this.mainWindow1.TabIndex = 0;
			// 
			// EspSharpGui
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1021, 548);
			this.Controls.Add(this.mainWindow1);
			this.Name = "EspSharpGui";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ESP#";
			this.ResumeLayout(false);

		}

		#endregion
		private Controls.MainWindow mainWindow1;
	}
}

