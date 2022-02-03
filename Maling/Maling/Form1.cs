using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Maling
{
    public partial class GeneralWindow : Form
    {
        Bitmap drawingField;
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;

        public GeneralWindow()
        {
            InitializeComponent();
            g = Drawing.CreateGraphics();
            drawingField = new Bitmap(Drawing.Bounds.Width, Drawing.Bounds.Height);
            g = Graphics.FromImage(drawingField);
            g.FillRectangle(Brushes.White, 0, 0, Drawing.Bounds.Width, Drawing.Bounds.Height);
            Drawing.Image = drawingField;
            pen = new Pen(Color.Black, 5);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Når der trykkes på SaveButton
            Stream fileStream;
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Drawing.jpeg";
            saveFile.Filter = "jpeg (*.jpeg)|*.jpeg";
            saveFile.FilterIndex = 1;
            saveFile.RestoreDirectory = true;
            if (saveFile.FileName != "")
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    
                    if ((fileStream = saveFile.OpenFile()) != null)
                    {
                        Drawing.Image.Save(fileStream, ImageFormat.Jpeg);
                        fileStream.Close();
                    }
                }
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            //Når der trykkes på OpenButton
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = @"c:\\";
            openFile.Filter = "jpeg (*.jpeg)|*.jpeg";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Drawing.Image = null;
                Stream fileStream = openFile.OpenFile();

                g.DrawImage(Image.FromStream(fileStream), 0, 0);
                fileStream.Close();
                Drawing.Image = drawingField;
            }
        }


        public void GeneralWindow_Load(object sender, EventArgs e)
        {
            //Når det hele loader
            
        }

        private void Drawing_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void Drawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
                Drawing.Image = drawingField;
            }
        }

        private void Drawing_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }
    }
}
