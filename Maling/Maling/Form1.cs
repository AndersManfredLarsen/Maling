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
        Bitmap savedDrawing;
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
            drawingField = new Bitmap(Drawing.Bounds.Width, Drawing.Bounds.Height);
            savedDrawing = new Bitmap(Drawing.Bounds.Width, Drawing.Bounds.Height);
            g = Graphics.FromImage(drawingField);
            g.FillRectangle(Brushes.White, 0, 0, Drawing.Bounds.Width, Drawing.Bounds.Height);
            Drawing.Image = drawingField;
            pen = new Pen(Color.Black, 5);

            newColor = Color.Black;
            width = 5;
            BrushSize.Value = 5;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Når SaveButton bliver trykket på
            saveFile();
        }

        private void GeneralWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            int equalElements = 0; //Hvor mange pixels er ens

            Bitmap downScaledCurrent = new Bitmap(drawingField, new Size(16, 16)); //Downscaled version af tegnebrætter
            Bitmap downScaledLastSaved = new Bitmap(savedDrawing, new Size(16, 16)); //Downscaled version af seneste gemte tegning

            //Loop igennem alle pixels
            for (int x = 0; x < downScaledCurrent.Height; x++)
            {
                for (int y = 0; y < downScaledCurrent.Width; y++)
                {
                    //Hvis pixel er ens
                    if (downScaledCurrent.GetPixel(x, y).GetBrightness() == downScaledLastSaved.GetPixel(x, y).GetBrightness())
                    {
                        equalElements += 1;
                    }
                    //Hvis pixel ikke er ens
                    else break;
                }
            }

            //Hvis de to tegninger ikke er ens
            if (equalElements != 16 * 16)
            {
                //Laver et nyt vindue til at gemme eller ikke gemme
                catchMissClose catchMissCloseForm = new catchMissClose();
                DialogResult dialog = catchMissCloseForm.ShowDialog();

                //Hvis brugeren trykker gem
                if (dialog == DialogResult.Yes)
                {
                    //Køre gem methoden
                    saveFile();
                }
            }
        }

        void saveFile()
        {
            Stream fileStream;
            SaveFileDialog saveFile = new SaveFileDialog();

            //Indstillinger til "saveFile"
            saveFile.FileName = "Drawing.jpeg";
            saveFile.Filter = "jpeg (*.jpeg)|*.jpeg";
            saveFile.FilterIndex = 1;
            saveFile.RestoreDirectory = true;

            //Hvis der trykkes gem
            if (saveFile.ShowDialog() == DialogResult.OK)
                //Hvis filens navn ikke er tomt
                if (saveFile.FileName != "")
                    //Hvis fillokationen eksistere
                    if ((fileStream = saveFile.OpenFile()) != null)
                    {
                        Drawing.Image.Save(fileStream, ImageFormat.Jpeg); //Filen gemmes
                        fileStream.Close(); //Filen lukkes
                        savedDrawing = new Bitmap(Drawing.Image);
                    }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            //Når der trykkes på OpenButton
            OpenFileDialog openFile = new OpenFileDialog();

            //Indstillinger for "openFile"
            openFile.InitialDirectory = @"c:\\";
            openFile.Filter = "jpeg (*.jpeg)|*.jpeg";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;

            //Hvis der trykkes åben
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Drawing.Image = null; //Fjerner tegning til ingenting
                Stream fileStream = openFile.OpenFile();

                g.DrawImage(Image.FromStream(fileStream), 0, 0);//Tegner nye tegning på bitmap
                fileStream.Close(); //Lukker fil
                Drawing.Image = drawingField; //Indsætter tegningen på tegnebrættet
                savedDrawing = new Bitmap(Drawing.Image); 
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            PopupForm popup = new PopupForm(); //Åbner popup vindue og spørger om du ville slette alt
            DialogResult popupResult = popup.ShowDialog(); //Indeholder hvad der trykkes på

            //Hvis der trykkes "Clear"
            if (popupResult == DialogResult.OK)
            {
                g.Clear(Color.White); //Rydder bitmap
                Drawing.Image = drawingField; //Rydder tegnebrættet
            }

            popup.Dispose();
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
                Drawing.Image = drawingField;
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
