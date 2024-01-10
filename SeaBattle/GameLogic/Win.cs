using SeaBattle.GameElements;

namespace SeaBattle.GameLogic;

public static class Win
{
    public static void WinCases()
    {
        if (Board.EnemyShips == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You win!");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            
            Menu.Menu.ShowMenu();
        }
        else if (Board.PlayerShips == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You lose.");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            
            Menu.Menu.ShowMenu();
        }
    }
}
