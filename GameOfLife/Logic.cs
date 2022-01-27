using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Logic
    {
        private bool[,] field;
        private readonly int cols;
        private readonly int rows;
        private Random random = new Random();

        public Logic(int cols, int rows, int density)
        {
            this.cols = cols;
            this.rows = rows;
            field = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
                for (int y = 0; y < rows; y++)
                    field[x, y] = random.Next(density) == 0;
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

        private void Generation()
        {
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
                   }
            }

            field = newField;
        }
    }
}
