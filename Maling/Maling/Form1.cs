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
        public GeneralWindow()
        {
            InitializeComponent();
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
    }
}
