
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
            ((System.ComponentModel.ISupportInitialize)(this.BrushSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drawing)).BeginInit();
            this.SuspendLayout();
            // 
            // RedColorBtn
            // 
            this.RedColorBtn.BackColor = System.Drawing.Color.Red;
            this.RedColorBtn.Location = new System.Drawing.Point(363, 15);
            this.RedColorBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RedColorBtn.Name = "RedColorBtn";
            this.RedColorBtn.Size = new System.Drawing.Size(80, 37);
            this.RedColorBtn.TabIndex = 5;
            this.RedColorBtn.Text = "Red";
            this.RedColorBtn.UseVisualStyleBackColor = false;
            this.RedColorBtn.Click += new System.EventHandler(this.RedColorBtn_Click);
            // 
            // GreenColorBtn
            // 
            this.GreenColorBtn.BackColor = System.Drawing.Color.Lime;
            this.GreenColorBtn.Location = new System.Drawing.Point(103, 15);
            this.GreenColorBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GreenColorBtn.Name = "GreenColorBtn";
            this.GreenColorBtn.Size = new System.Drawing.Size(80, 37);
            this.GreenColorBtn.TabIndex = 1;
            this.GreenColorBtn.Text = "Green";
            this.GreenColorBtn.UseVisualStyleBackColor = false;
            this.GreenColorBtn.Click += new System.EventHandler(this.GreenColorBtn_Click);
            // 
            // BlueColorBtn
            // 
            this.BlueColorBtn.BackColor = System.Drawing.Color.Blue;
            this.BlueColorBtn.Location = new System.Drawing.Point(188, 15);
            this.BlueColorBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BlueColorBtn.Name = "BlueColorBtn";
            this.BlueColorBtn.Size = new System.Drawing.Size(80, 37);
            this.BlueColorBtn.TabIndex = 2;
            this.BlueColorBtn.Text = "Blue";
            this.BlueColorBtn.UseVisualStyleBackColor = false;
            this.BlueColorBtn.Click += new System.EventHandler(this.BlueColorBtn_Click);
            // 
            // YellowColorBtn
            // 
            this.YellowColorBtn.BackColor = System.Drawing.Color.Yellow;
            this.YellowColorBtn.Location = new System.Drawing.Point(275, 15);
            this.YellowColorBtn.Margin = new System.Windows.Forms.Padding(4);
            this.YellowColorBtn.Name = "YellowColorBtn";
            this.YellowColorBtn.Size = new System.Drawing.Size(80, 37);
            this.YellowColorBtn.TabIndex = 3;
            this.YellowColorBtn.Text = "Yellow";
            this.YellowColorBtn.UseVisualStyleBackColor = false;
            this.YellowColorBtn.Click += new System.EventHandler(this.YellowColorBtn_Click);
            // 
            // BrushSize
            // 
            this.BrushSize.LargeChange = 1;
            this.BrushSize.Location = new System.Drawing.Point(479, 29);
            this.BrushSize.Margin = new System.Windows.Forms.Padding(4);
            this.BrushSize.Name = "BrushSize";
            this.BrushSize.Size = new System.Drawing.Size(139, 56);
            this.BrushSize.TabIndex = 7;
            this.BrushSize.Scroll += new System.EventHandler(this.BrushSize_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Brush size";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(971, 15);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(80, 37);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EraserButton
            // 
            this.EraserButton.Location = new System.Drawing.Point(653, 15);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(79, 37);
            this.EraserButton.TabIndex = 8;
            this.EraserButton.Text = "Eraser";
            this.EraserButton.UseVisualStyleBackColor = true;
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
            // 
            // BlackColorBtn
            // 
            this.BlackColorBtn.BackColor = System.Drawing.Color.Black;
            this.BlackColorBtn.ForeColor = System.Drawing.Color.White;
            this.BlackColorBtn.Location = new System.Drawing.Point(16, 15);
            this.BlackColorBtn.Name = "BlackColorBtn";
            this.BlackColorBtn.Size = new System.Drawing.Size(80, 37);
            this.BlackColorBtn.TabIndex = 0;
            this.BlackColorBtn.Text = "Black";
            this.BlackColorBtn.UseVisualStyleBackColor = false;
            this.BlackColorBtn.Click += new System.EventHandler(this.BlackColorBtn_Click);
            // 
            // Drawing
            // 
            this.Drawing.BackColor = System.Drawing.Color.White;
            this.Drawing.Location = new System.Drawing.Point(16, 68);
            this.Drawing.Name = "Drawing";
            this.Drawing.Size = new System.Drawing.Size(1039, 474);
            this.Drawing.TabIndex = 10;
            this.Drawing.TabStop = false;
            this.Drawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.Drawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.Drawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // GeneralWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button EraserButton;
        private System.Windows.Forms.Button BlackColorBtn;
        private System.Windows.Forms.PictureBox Drawing;
    }
}

