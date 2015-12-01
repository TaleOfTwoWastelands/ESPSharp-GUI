﻿namespace ESPSharp_GUI.DockableForms
{
	partial class MessagesWindow
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
			this.rtbMessages = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// rtbMessages
			// 
			this.rtbMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbMessages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbMessages.HideSelection = false;
			this.rtbMessages.Location = new System.Drawing.Point(0, 0);
			this.rtbMessages.Margin = new System.Windows.Forms.Padding(4);
			this.rtbMessages.Name = "rtbMessages";
			this.rtbMessages.ReadOnly = true;
			this.rtbMessages.Size = new System.Drawing.Size(619, 555);
			this.rtbMessages.TabIndex = 0;
			this.rtbMessages.Text = "";
			// 
			// MessagesWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 555);
			this.CloseButton = false;
			this.CloseButtonVisible = false;
			this.Controls.Add(this.rtbMessages);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HideOnClose = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MessagesWindow";
			this.Text = "Messages";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbMessages;
	}
}