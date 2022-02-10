
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
            this.aysClearButton.Location = new System.Drawing.Point(103, 85);
            this.aysClearButton.Name = "aysClearButton";
            this.aysClearButton.Size = new System.Drawing.Size(60, 30);
            this.aysClearButton.TabIndex = 0;
            this.aysClearButton.Text = "Clear";
            this.aysClearButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you sure?";
            // 
            // aysCancelButton
            // 
            this.aysCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.aysCancelButton.Location = new System.Drawing.Point(169, 85);
            this.aysCancelButton.Name = "aysCancelButton";
            this.aysCancelButton.Size = new System.Drawing.Size(60, 30);
            this.aysCancelButton.TabIndex = 1;
            this.aysCancelButton.Text = "Cancel";
            this.aysCancelButton.UseVisualStyleBackColor = true;
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 153);
            this.Controls.Add(this.aysCancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aysClearButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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