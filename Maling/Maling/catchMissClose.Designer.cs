
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
            this.CatchSaveCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CatchSaveButton
            // 
            this.CatchSaveButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.CatchSaveButton.Location = new System.Drawing.Point(88, 79);
            this.CatchSaveButton.Name = "CatchSaveButton";
            this.CatchSaveButton.Size = new System.Drawing.Size(80, 30);
            this.CatchSaveButton.TabIndex = 0;
            this.CatchSaveButton.Text = "Save";
            this.CatchSaveButton.UseVisualStyleBackColor = true;
            // 
            // CatchSaveCancelButton
            // 
            this.CatchSaveCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CatchSaveCancelButton.Location = new System.Drawing.Point(174, 79);
            this.CatchSaveCancelButton.Name = "CatchSaveCancelButton";
            this.CatchSaveCancelButton.Size = new System.Drawing.Size(80, 30);
            this.CatchSaveCancelButton.TabIndex = 1;
            this.CatchSaveCancelButton.Text = "Cancel";
            this.CatchSaveCancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = " Are you sure you dont want to save?";
            // 
            // catchMissClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CatchSaveCancelButton);
            this.Controls.Add(this.CatchSaveButton);
            this.Name = "catchMissClose";
            this.Text = "catchMissClose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CatchSaveButton;
        private System.Windows.Forms.Button CatchSaveCancelButton;
        private System.Windows.Forms.Label label1;
    }
}