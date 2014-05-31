using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaChess
{
    public class SeaChess
    {
        public static void Main()
        {
            Game game = new Game();

            Introduction();
            game.Play();
        }

        private static void Introduction()
        {
            Console.WriteLine("Hello and welcome to the ultimate Sea Chess game!");
            Console.WriteLine("We hope you will enjoy your playing session.");
            Console.WriteLine("And wish you good luck!");
        }
    }
}
