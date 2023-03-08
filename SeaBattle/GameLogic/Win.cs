using static SeaBattle.Graphics.Board;
namespace SeaBattle.GameLogic
{
    internal static class Win
    {
        public static void WinCases()
        {
            if (enemyCells[2, 2] == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win!");
                Console.ResetColor();
                Task t = Task.Delay(2000);
                t.Wait();
                Console.Clear();
                Environment.Exit(0);
            }
            else if (playerCells[1, 2] == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose.");
                Console.ResetColor();
                Task t = Task.Delay(2000);
                t.Wait();
                Console.Clear();
                Environment.Exit(0);
            }
        }
    }
}