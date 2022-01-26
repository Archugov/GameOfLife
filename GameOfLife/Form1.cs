using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        private bool[,] field;
        private int cols;
        private int rows;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            if (timer1.Enabled)
                return;

            numResolution.Enabled = false;
            numDensity.Enabled = false;

            cols = pictureBox1.Width / resolution;
            rows = pictureBox1.Height / resolution;

            field = new bool[cols, rows];
            
            Random random = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {

                }
            }

            resolution = (int)numResolution.Value;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            graphics.FillRectangle(Brushes.Red, 0, 0, resolution, resolution);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void butStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void butStop_Click(object sender, EventArgs e)
        {

        }
    }
}
