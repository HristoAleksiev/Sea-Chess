namespace SeaChess
{
    using System;

    public class FieldRenderer
    {
        public static void Render()
        {
            Field field = new Field();

            Console.WriteLine(" -- -- --");
            Console.WriteLine("| " + field.CellValues[0, 0] + "|" + field.CellValues[0, 1] + " |" + field.CellValues[2, 2] + " |");
            Console.WriteLine(" -- -- --");
            Console.WriteLine("| " + field.CellValues[1, 0] + "|" + field.CellValues[1, 1] + " |" + field.CellValues[1, 2] + " |");
            Console.WriteLine(" -- -- --");
            Console.WriteLine("| " + field.CellValues[2, 0] + "|" + field.CellValues[2, 1] + " |" + field.CellValues[2, 2] + " |");
            Console.WriteLine(" -- -- --");
        }
    }
}
