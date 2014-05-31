using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaChess
{
    public class FieldRenderer
    {
        public static void Render()
        {
            Field field = new Field();

            Console.WriteLine(" -- -- --");
            Console.WriteLine("| " + field.Grid[0, 0] + "|" + field.Grid[0, 1] + " |" + field.Grid[2, 2] + " |");
            Console.WriteLine(" -- -- --");
            Console.WriteLine("| " + field.Grid[1, 0] + "|" + field.Grid[1, 1] + " |" + field.Grid[1, 2] + " |");
            Console.WriteLine(" -- -- --");
            Console.WriteLine("| " + field.Grid[2, 0] + "|" + field.Grid[2, 1] + " |" + field.Grid[2, 2] + " |");
            Console.WriteLine(" -- -- --");
        }
    }
}
