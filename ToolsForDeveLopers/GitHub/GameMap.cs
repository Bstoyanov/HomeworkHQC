using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub
{
    class GameMap
    {
        private char[,] map;
        private int rowsNumber;
        private int colsNumber;

        public GameMap(int rows,int cols)
        {
            this.map = new char[rows,cols];
            this.Initialize(this.map,rows,cols); 
        }
        private void Initialize(char[,] map,int rows,int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    map[i, j] = '.';
                }
            }
        }
    }
}
