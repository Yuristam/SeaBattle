namespace SeaBattle.GameLogic
{
    internal static class Win
    {
        public static int enemyShips = 5;
        public static int playerShips = 5;
        public static void WinCases()
        {
            if (enemyShips == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                Program.Main();
            }
            else if (playerShips == 0)
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