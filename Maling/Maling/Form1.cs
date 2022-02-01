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
        public GeneralWindow()
        {
            InitializeComponent();
            g = Drawing.CreateGraphics();
            pen = new Pen(Color.Black, 5);
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;

        }
    }
}
