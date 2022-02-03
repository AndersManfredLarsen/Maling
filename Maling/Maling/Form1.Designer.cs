
namespace Maling
{
    partial class GeneralWindow
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
            this.RedColorBtn = new System.Windows.Forms.Button();
            this.GreenColorBtn = new System.Windows.Forms.Button();
            this.BlueColorBtn = new System.Windows.Forms.Button();
            this.YellowColorBtn = new System.Windows.Forms.Button();
            this.BrushSize = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.Drawing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BrushSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drawing)).BeginInit();
            this.SuspendLayout();
            // 
            // RedColorBtn
            // 
            this.RedColorBtn.BackColor = System.Drawing.Color.Red;
            this.RedColorBtn.Location = new System.Drawing.Point(12, 12);
            this.RedColorBtn.Name = "RedColorBtn";
            this.RedColorBtn.Size = new System.Drawing.Size(60, 30);
            this.RedColorBtn.TabIndex = 0;
            this.RedColorBtn.Text = "Red";
            this.RedColorBtn.UseVisualStyleBackColor = false;
            // 
            // GreenColorBtn
            // 
            this.GreenColorBtn.BackColor = System.Drawing.Color.Lime;
            this.GreenColorBtn.Location = new System.Drawing.Point(77, 12);
            this.GreenColorBtn.Name = "GreenColorBtn";
            this.GreenColorBtn.Size = new System.Drawing.Size(60, 30);
            this.GreenColorBtn.TabIndex = 1;
            this.GreenColorBtn.Text = "Green";
            this.GreenColorBtn.UseVisualStyleBackColor = false;
            // 
            // BlueColorBtn
            // 
            this.BlueColorBtn.BackColor = System.Drawing.Color.Blue;
            this.BlueColorBtn.Location = new System.Drawing.Point(141, 12);
            this.BlueColorBtn.Name = "BlueColorBtn";
            this.BlueColorBtn.Size = new System.Drawing.Size(60, 30);
            this.BlueColorBtn.TabIndex = 2;
            this.BlueColorBtn.Text = "Blue";
            this.BlueColorBtn.UseVisualStyleBackColor = false;
            // 
            // YellowColorBtn
            // 
            this.YellowColorBtn.BackColor = System.Drawing.Color.Yellow;
            this.YellowColorBtn.Location = new System.Drawing.Point(206, 12);
            this.YellowColorBtn.Name = "YellowColorBtn";
            this.YellowColorBtn.Size = new System.Drawing.Size(60, 30);
            this.YellowColorBtn.TabIndex = 3;
            this.YellowColorBtn.Text = "Yellow";
            this.YellowColorBtn.UseVisualStyleBackColor = false;
            // 
            // BrushSize
            // 
            this.BrushSize.LargeChange = 1;
            this.BrushSize.Location = new System.Drawing.Point(271, 23);
            this.BrushSize.Name = "BrushSize";
            this.BrushSize.Size = new System.Drawing.Size(104, 45);
            this.BrushSize.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Brush size";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(728, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(60, 30);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(662, 12);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(60, 30);
            this.OpenButton.TabIndex = 8;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // Drawing
            // 
            this.Drawing.BackColor = System.Drawing.Color.White;
            this.Drawing.Image = global::Maling.Properties.Resources.WhiteOut;
            this.Drawing.Location = new System.Drawing.Point(12, 61);
            this.Drawing.Name = "Drawing";
            this.Drawing.Size = new System.Drawing.Size(776, 377);
            this.Drawing.TabIndex = 9;
            this.Drawing.TabStop = false;
            this.Drawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drawing_MouseDown);
            this.Drawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drawing_MouseMove);
            this.Drawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drawing_MouseUp);
            // 
            // GeneralWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Drawing);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrushSize);
            this.Controls.Add(this.YellowColorBtn);
            this.Controls.Add(this.BlueColorBtn);
            this.Controls.Add(this.GreenColorBtn);
            this.Controls.Add(this.RedColorBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GeneralWindow";
            this.Text = "Backalley Paint";
            this.Load += new System.EventHandler(this.GeneralWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BrushSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drawing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RedColorBtn;
        private System.Windows.Forms.Button GreenColorBtn;
        private System.Windows.Forms.Button BlueColorBtn;
        private System.Windows.Forms.Button YellowColorBtn;
        private System.Windows.Forms.TrackBar BrushSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.PictureBox Drawing;
    }
}

