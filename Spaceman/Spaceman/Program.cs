using System;

namespace Spaceman
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            g.Greet();

            while (!g.DidWin() || !g.DidLose())
            {
                g.Display();
                g.Ask();

                if (g.DidWin())
                {
                    Console.WriteLine("You WIN!");
                    break;
                }

                if (g.DidLose())
                {
                    Console.WriteLine("You LOST!");
                    break;
                }
            }
        }
    }
}