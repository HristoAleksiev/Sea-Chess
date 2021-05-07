namespace SeaChess
{
    using System;

    static class Text
    {
        public static void Write(TextContent content){
            switch (content)
            {
                case TextContent.Intro:
                    Console.WriteLine("Hello and welcome to the ultimate Sea Chess game!\n" +
                                "We hope you will enjoy your playing session.\n" +
                                "And wish you good luck!");
                    break;
                case TextContent.YouGo:
                    Console.WriteLine("You go first!");
                    break;
                case TextContent.ComputerGoes:
                    Console.WriteLine("Computer goes first!");
                    break;
                case TextContent.Prompt:
                    Console.WriteLine("Shall we decide who goes first?\nPick: Heads(1) or Tails(2) and let's toss the coin. ");
                    break;
                default:
                    break;
            }
       }
    }
}
