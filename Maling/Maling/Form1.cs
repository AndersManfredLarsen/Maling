using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maling
{
    public partial class GeneralWindow : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        Color newColor;
        int width;

        public GeneralWindow()
        {
            InitializeComponent();
            g = Drawing.CreateGraphics();

            pen = new Pen(Color.Black, 5);

            newColor = Color.Black;
            width = 5;
            BrushSize.Value = 5;
        }

        Bitmap drawingField;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Når SaveButton bliver trykket på
            Graphics g = Graphics.FromImage(drawingField);
        }

        public void GeneralWindow_Load(object sender, EventArgs e)
        {
            //Når det hele loader
            drawingField = new Bitmap(Drawing.Bounds.Width, Drawing.Bounds.Height);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pen.Color = newColor;
            pen.Width = width;
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void RedColorBtn_Click(object sender, EventArgs e)
        {
            newColor = Color.Red;
        }

        private void GreenColorBtn_Click(object sender, EventArgs e)
        {
            newColor = Color.Green;
        }

        private void BlueColorBtn_Click(object sender, EventArgs e)
        {
            newColor = Color.Blue;
        }

        private void YellowColorBtn_Click(object sender, EventArgs e)
        {
            newColor = Color.Yellow;
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            newColor = Color.White;
        }
        private void BlackColorBtn_Click(object sender, EventArgs e)
        {
            newColor = Color.Black;
        }

        private void BrushSize_Scroll(object sender, EventArgs e)
        {
            width = BrushSize.Value;
        }
    }
}
