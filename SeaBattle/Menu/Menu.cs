using SeaBattle.Graphics;

namespace SeaBattle.Menu
{
    internal class Menu
    {
        public static void ShowMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Welcome to The Sea Battle game.");
                for (int i = 0; i < Console.BufferWidth; i++)
                {
                    Console.Write('=');
                }
                Console.Write("1. ’start’ (or ‘s’) - start the game.\r\n" +
                "2. ‘quit’ (or ‘q’) - quit the game.\r\n>");
                Console.ResetColor();

                string userInput = Console.ReadLine().ToLower().Trim();
                if (userInput == "start" || userInput == "s")
                {
                    Console.Clear();
                    Board.DrawBoard();
                    break;
                }
                else if (userInput == "quit" || userInput == "q")
                {
                    Console.Clear();
                    ExitGame();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("There is no such command, please try another command.");
                    Console.ResetColor();
                    Task t = Task.Delay(2000);
                    t.Wait();
                }
            }
        }
        public static void ExitGame()
        {
            Console.WriteLine("You have quitted the game!");
            Environment.Exit(0);
        }
    }
}
