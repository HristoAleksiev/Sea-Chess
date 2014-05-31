using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaChess
{
    public class Field
    {
        private char[,] grid = {{' ', ' ', ' '}, 
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}};

        public char[,] Grid
        {
            get
            {
                return grid;
            }
            set
            {
                grid = value;
            }
        }

        public void FillCell(ushort[] cell, char sign)
        {
            Grid[cell[0],cell[1]] = sign;
        }
    }
}
