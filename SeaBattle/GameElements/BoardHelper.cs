using SeaBattle.GameLogic;
using SeaBattle.Menu;
using static SeaBattle.GameElements.Board;

namespace SeaBattle.GameElements;

public static class BoardHelper
{
    public static char[,] FillBoardWithEmptyWaves(char[,] cells)
    {
        for (int i = 0; i < cells.GetLength(0); i++)
        {
            for (int j = 0; j < cells.GetLength(1); j++)
            {
                cells[i, j] = '~';
            }
        }

        return cells;
    }

    public static char[,] DrawCurrentBoardState(char[,] cells)
    {
        for (int i = 0; i < cells.GetLength(0); i++)
        {
            for (int j = 0; j < cells.GetLength(1); j++)
            {
                if (cells[i, j] == '#') cells[i, j] = '#';
                else if (cells[i, j] == 'X') cells[i, j] = 'X';
                else if (cells[i, j] == '*') cells[i, j] = '*';
                else cells[i, j] = '~';
            }
        }

        return cells;
    }

    public static void DrawMapWithEnemyShips()
    {
        Console.Clear();
        Console.ResetColor();
        Console.WriteLine("Enemy's Ships: ");

        MenuHelper.DrawCoordinates();

        Console.WriteLine();

        for (int i = 0; i < EnemyCells.GetLength(0); i++)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;

            for (int j = 0; j < EnemyCells.GetLength(1); j++)
            {
                if (EnemyCells[i, j] == '*')
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }

                Console.Write(EnemyCells[i, j] + " ");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }

            Console.ResetColor();
            Console.WriteLine(i + 1);
        }
    }

    public static void DrawMapWithPlayerShips()
    {
        Console.SetCursorPosition(30, 0);
        Console.WriteLine("Your Ships: ");
        Console.SetCursorPosition(30, 1);

        MenuHelper.DrawCoordinates();

        Console.WriteLine();

        for (int i = 0; i < PlayerCells.GetLength(0); i++)
        {

            Console.SetCursorPosition(30, i + 2);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;

            for (int j = 0; j < PlayerCells.GetLength(1); j++)
            {
                if (PlayerCells[i, j] == '#')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (PlayerCells[i, j] == '*')
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }

                Console.Write(PlayerCells[i, j] + " ");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }

            Console.ResetColor();
            Console.WriteLine(i + 1);
        }
    }

    public static void PrintCurrentGameStatistics()
    {
        Console.SetCursorPosition(60, 0);
        Console.WriteLine($"Enemy's ships left: {EnemyShips}");
        Console.SetCursorPosition(60, 1);
        Console.WriteLine($"Your ships left: {PlayerShips}");
        Console.SetCursorPosition(60, 2);
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write($"X - missed, ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($"* - shot, ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"# - your ships");
        Console.ResetColor();
    }

    public static void PutPlayerShips()
    {
        for (int i = 0; i < 5; i++)
        {
            Input.UserShips();
        }
    }
}
