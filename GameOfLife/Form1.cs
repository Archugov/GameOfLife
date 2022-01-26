using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        private bool[,] field;
        private int cols;
        private int rows;
        private int currentGeneration = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            if (timer1.Enabled)
                return;

            currentGeneration = 0;
            Text = $"Генерация {currentGeneration}";

            numResolution.Enabled = false;
            numDensity.Enabled = false;

            resolution = (int)numResolution.Value;
            cols = pictureBox1.Width / resolution;
            rows = pictureBox1.Height / resolution;

            field = new bool[cols, rows];
            
            Random random = new Random();
            for (int x = 0; x < cols; x++)
                for (int y = 0; y < rows; y++)
                    field[x,y] = random.Next((int)numDensity.Value) == 0;

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            graphics.FillRectangle(Brushes.Red, 0, 0, resolution, resolution);

            timer1.Start();
        }

        private void StopGame()
        {
            if (!timer1.Enabled)
                return;

            timer1.Stop();

            numDensity.Enabled = true;
            numResolution.Enabled = true;
        }

        private void Generation()
        {
            graphics.Clear(Color.Black);

            var newField = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighboursCount = fieldNeighbours(x, y);
                    var hasLife = field[x, y];

                    if (!hasLife && neighboursCount == 3)
                        newField[x, y] = true;
                    else if (hasLife && neighboursCount < 2 || neighboursCount > 3)
                        newField[x, y] = false;
                    else
                        newField[x, y] = field[x, y];
                    if (hasLife)
                        graphics.FillRectangle(Brushes.Red, x * resolution, y * resolution, resolution, resolution);
                }
            }

            field = newField;

            pictureBox1.Refresh();
            Text = $"Генерация {++currentGeneration}";
        }

        private int fieldNeighbours(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;
                    var isSelfCheck = col == x && row == y;
                    var hasLife = field[col, row];

                    if (hasLife && !isSelfCheck)
                        count++;
                }
            }

            return count;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Generation();
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
                return;

            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;

                var validatePos = ValidateMousePos(x, y);
                if (validatePos)
                    field[x, y] = true;
            }

            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var validatePos = ValidateMousePos(x, y);
                if (validatePos)
                    field[x, y] = false;
            }
        }

        private bool ValidateMousePos(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = $"Генерация {++currentGeneration}";
        }
    }
}
