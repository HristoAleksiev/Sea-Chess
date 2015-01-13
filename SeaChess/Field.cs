namespace SeaChess
{
    using System;

    public class Field
    {
        private char[,] cellValues = {{' ', ' ', ' '}, 
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}};

        public char[,] CellValues 
        {
            get 
            {
                return cellValues; 
            }
            set
            {
                cellValues = value;
            }
        
        }

        public void FillCell(ushort[] cell, char sign)
        {

        }
    }
}
