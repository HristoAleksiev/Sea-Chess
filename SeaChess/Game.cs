using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaChess
{
    public class Game
    {
        private delegate void firstMoveTurn();
        private delegate void secondMoveTurn();
        private firstMoveTurn firstMove;
        private secondMoveTurn secondMove;


        public void Play()
        {
            int chek = 0;
            while (chek < 1)
            {
                FieldRenderer.Render();
                Turn();
                firstMove();
                secondMove();
                chek++;
            }
        }

        private void Turn()
        {
            Random random = new Random();
            Person person = new Person();
            ArtificialInteligence ai = new ArtificialInteligence();
            ushort userInput;
            ushort randomNumber;

            Console.WriteLine("First let's decide who goes first!");
            Console.Write("Pick a number between 10 and 30:");

            userInput = ushort.Parse(Console.ReadLine());
            Console.WriteLine(userInput);
            randomNumber = (ushort)random.Next(0, 41);
            Console.WriteLine(randomNumber);
            
            if (userInput > randomNumber)
            {
                firstMove = person.Move;
                secondMove = ai.Move;
                Console.WriteLine("You go first!");
            }
            else
            {
                firstMove = ai.Move;
                secondMove = person.Move;
                Console.WriteLine("Computer goes first!");
            }
        }
    }
}
