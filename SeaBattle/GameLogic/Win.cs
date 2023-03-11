using SeaBattle.Graphics;

namespace SeaBattle.GameLogic
{
    internal static class Win
    {/*
        public static int enemyShips = 0;
        public static int playerShips = 0;*/
        public static void WinCases()
        {
            if (Board.enemyShips == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                Program.Main();
            }
            else if (Board.playerShips == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose.");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                Program.Main();
            }
        }
    }
}