﻿namespace ESPSharp_GUI.DockableForms
{
	partial class ScriptEditorWindow
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
			this.scriptHighlighterTextBox1 = new ScriptEditor.ScriptHighlighterTextBox();
			this.SuspendLayout();
			// 
			// scriptHighlighterTextBox1
			// 
			this.scriptHighlighterTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scriptHighlighterTextBox1.Location = new System.Drawing.Point(0, 0);
			this.scriptHighlighterTextBox1.Name = "scriptHighlighterTextBox1";
			this.scriptHighlighterTextBox1.Size = new System.Drawing.Size(507, 360);
			this.scriptHighlighterTextBox1.TabIndex = 0;
			// 
			// ScriptEditorWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 360);
			this.Controls.Add(this.scriptHighlighterTextBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HideOnClose = true;
			this.Name = "ScriptEditorWindow";
			this.Text = "ScriptEditorWindow";
			this.ResumeLayout(false);

		}

		#endregion

		private ScriptEditor.ScriptHighlighterTextBox scriptHighlighterTextBox1;
	}
}