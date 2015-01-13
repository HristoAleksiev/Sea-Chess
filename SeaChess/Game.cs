namespace SeaChess
{
    using System;

    public class Game
    {
        private Random random = new Random();
        private string randomSelection;
        private string decision;

        public void Run()
        {
            //  Welcome the player!
            Text.Write(TextContent.Intro);
            
            //  Main loop
            do
            {
                FieldRenderer.Render();
                
                DecideTurn();

            } while (true);
        }

        private void DecideTurn()
        {
            Text.Write(TextContent.Prompt);

            decision = Console.ReadKey(true).KeyChar.ToString();
            randomSelection = random.Next(1, 3).ToString();

            Console.Clear();

            if (randomSelection.Equals(decision))
            {
                Text.Write(TextContent.YouGo);
            }
            else
            {
                Text.Write(TextContent.ComputerGoes);
            }
        }
    }
}
