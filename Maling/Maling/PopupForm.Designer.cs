﻿
namespace Maling
{
    partial class PopupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupForm));
            this.aysClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aysCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aysClearButton
            // 
            this.aysClearButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.aysClearButton.Location = new System.Drawing.Point(70, 69);
            this.aysClearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aysClearButton.Name = "aysClearButton";
            this.aysClearButton.Size = new System.Drawing.Size(52, 24);
            this.aysClearButton.TabIndex = 0;
            this.aysClearButton.Text = "Clear";
            this.aysClearButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you sure?";
            // 
            // aysCancelButton
            // 
            this.aysCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.aysCancelButton.Location = new System.Drawing.Point(127, 69);
            this.aysCancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aysCancelButton.Name = "aysCancelButton";
            this.aysCancelButton.Size = new System.Drawing.Size(53, 24);
            this.aysCancelButton.TabIndex = 1;
            this.aysCancelButton.Text = "Cancel";
            this.aysCancelButton.UseVisualStyleBackColor = true;
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 124);
            this.Controls.Add(this.aysCancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aysClearButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Are you sure?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aysClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aysCancelButton;
    }
}