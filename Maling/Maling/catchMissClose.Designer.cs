
namespace Maling
{
    partial class catchMissClose
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
            this.CatchSaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DontSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CatchSaveButton
            // 
            this.CatchSaveButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.CatchSaveButton.Location = new System.Drawing.Point(77, 82);
            this.CatchSaveButton.Name = "CatchSaveButton";
            this.CatchSaveButton.Size = new System.Drawing.Size(90, 30);
            this.CatchSaveButton.TabIndex = 0;
            this.CatchSaveButton.Text = "Save";
            this.CatchSaveButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Did you forget to save?";
            // 
            // DontSaveButton
            // 
            this.DontSaveButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.DontSaveButton.Location = new System.Drawing.Point(173, 82);
            this.DontSaveButton.Name = "DontSaveButton";
            this.DontSaveButton.Size = new System.Drawing.Size(90, 30);
            this.DontSaveButton.TabIndex = 2;
            this.DontSaveButton.Text = "Don\'t save";
            this.DontSaveButton.UseVisualStyleBackColor = true;
            // 
            // catchMissClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 153);
            this.Controls.Add(this.DontSaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CatchSaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "catchMissClose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot to save?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CatchSaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DontSaveButton;
    }
}