
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
            this.EraserButton = new System.Windows.Forms.Button();
            this.BlackColorBtn = new System.Windows.Forms.Button();
            this.Drawing = new System.Windows.Forms.PictureBox();
            this.SquareBt = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BrushSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drawing)).BeginInit();
            this.SuspendLayout();
            // 
            // RedColorBtn
            // 
            this.RedColorBtn.BackColor = System.Drawing.Color.Red;
            this.RedColorBtn.Location = new System.Drawing.Point(272, 12);
            this.RedColorBtn.Name = "RedColorBtn";
            this.RedColorBtn.Size = new System.Drawing.Size(60, 30);
            this.RedColorBtn.TabIndex = 5;
            this.RedColorBtn.Text = "Red";
            this.RedColorBtn.UseVisualStyleBackColor = false;
            this.RedColorBtn.Click += new System.EventHandler(this.RedColorBtn_Click);
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
            this.GreenColorBtn.Click += new System.EventHandler(this.GreenColorBtn_Click);
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
            this.BlueColorBtn.Click += new System.EventHandler(this.BlueColorBtn_Click);
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
            this.YellowColorBtn.Click += new System.EventHandler(this.YellowColorBtn_Click);
            // 
            // BrushSize
            // 
            this.BrushSize.LargeChange = 1;
            this.BrushSize.Location = new System.Drawing.Point(359, 24);
            this.BrushSize.Name = "BrushSize";
            this.BrushSize.Size = new System.Drawing.Size(104, 45);
            this.BrushSize.TabIndex = 7;
            this.BrushSize.Scroll += new System.EventHandler(this.BrushSize_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Brush size";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(728, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(60, 30);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EraserButton
            // 
            this.EraserButton.Location = new System.Drawing.Point(490, 12);
            this.EraserButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(59, 30);
            this.EraserButton.TabIndex = 8;
            this.EraserButton.Text = "Eraser";
            this.EraserButton.UseVisualStyleBackColor = true;
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
            // 
            // BlackColorBtn
            // 
            this.BlackColorBtn.BackColor = System.Drawing.Color.Black;
            this.BlackColorBtn.ForeColor = System.Drawing.Color.White;
            this.BlackColorBtn.Location = new System.Drawing.Point(12, 12);
            this.BlackColorBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BlackColorBtn.Name = "BlackColorBtn";
            this.BlackColorBtn.Size = new System.Drawing.Size(60, 30);
            this.BlackColorBtn.TabIndex = 0;
            this.BlackColorBtn.Text = "Black";
            this.BlackColorBtn.UseVisualStyleBackColor = false;
            this.BlackColorBtn.Click += new System.EventHandler(this.BlackColorBtn_Click);
            // 
            // Drawing
            // 
            this.Drawing.BackColor = System.Drawing.Color.White;
            this.Drawing.Location = new System.Drawing.Point(12, 55);
            this.Drawing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Drawing.Name = "Drawing";
            this.Drawing.Size = new System.Drawing.Size(779, 385);
            this.Drawing.TabIndex = 10;
            this.Drawing.TabStop = false;
            this.Drawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.Drawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.Drawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // SquareBt
            // 
            this.SquareBt.BackColor = System.Drawing.Color.Red;
            this.SquareBt.Location = new System.Drawing.Point(554, 12);
            this.SquareBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SquareBt.Name = "SquareBt";
            this.SquareBt.Size = new System.Drawing.Size(59, 30);
            this.SquareBt.TabIndex = 11;
            this.SquareBt.Text = "Square";
            this.SquareBt.UseVisualStyleBackColor = false;
            this.SquareBt.Click += new System.EventHandler(this.SquareBt_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(662, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(60, 30);
            this.openButton.TabIndex = 12;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // GeneralWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.SquareBt);
            this.Controls.Add(this.Drawing);
            this.Controls.Add(this.BlackColorBtn);
            this.Controls.Add(this.EraserButton);
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
        private System.Windows.Forms.Button EraserButton;
        private System.Windows.Forms.Button BlackColorBtn;
        private System.Windows.Forms.PictureBox Drawing;
        private System.Windows.Forms.Button SquareBt;
        private System.Windows.Forms.Button openButton;
    }
}

