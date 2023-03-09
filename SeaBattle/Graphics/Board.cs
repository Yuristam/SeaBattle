using SeaBattle.GameLogic;
using SeaBattle.Menu;

namespace SeaBattle.Graphics;
public class Board
{
    public static char[,] playerCells = new char[10, 10];
    public static char[,] enemyCells = new char[10, 10];
    public static void DrawBoard()
    {
        //=========================Player's cells==============================================
        for (int i = 0; i < playerCells.GetLength(0); i++)
        {
            for (int j = 0; j < playerCells.GetLength(1); j++)
            {
                playerCells[i, j] = '~';
            }
        }
        //=========================Enemy's cells==============================================
        for (int i = 0; i < enemyCells.GetLength(0); i++)
        {
            for (int j = 0; j < enemyCells.GetLength(1); j++)
            {
                enemyCells[i, j] = '~';
            }
        }
        //====================================================================================
        for (int i = 0; i < 5; i++)
        {
            Input.UserShips();
        }
        while (true)
        {
            //=============================My attack cells=====================================
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("Enemy's Ships");
            // Player's 1 2 3 4 5 6 7 8 9 10
            for (int k = 1; k < 11; k++)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < enemyCells.GetLength(0); i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int j = 0; j < enemyCells.GetLength(1); j++)
                {
                    if (enemyCells[i,j] == '*')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                       // Console.Beep(400,500);
                    }
                    Console.Write(enemyCells[i, j] + " ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.ResetColor();
                Console.WriteLine(i + 1);
            }
            //==================================================================================
            Console.WriteLine("\n");

            //=========================Enemies Attack to my cells===============================
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Your Ships");
            Console.SetCursorPosition(30, 1);
            for (int k = 1; k < 11; k++)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < playerCells.GetLength(0); i++)
            {
                Console.SetCursorPosition(30, i + 2);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int j = 0; j < playerCells.GetLength(1); j++)
                {
                    if (playerCells[i, j] == '#')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    if (playerCells[i, j] == '*')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        // Console.Beep(400,500);
                    }
                    Console.Write(playerCells[i, j] + " ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.ResetColor();
                Console.WriteLine(i + 1);
            }
            //===================================================================================


            for (int i = 0; i < Console.BufferWidth; i++)
            {
                Console.Write('=');
            }

            Console.SetCursorPosition(60, 0);
            Console.WriteLine($"Enemy's ships left: {Win.enemyShips}");
            Console.SetCursorPosition(60, 1);
            Console.WriteLine($"Your ships left: {Win.playerShips}");
            Console.SetCursorPosition(60, 2);
            Console.WriteLine("X - missed, * - shot, # - Your ships");

            Console.SetCursorPosition(0,13);
            Win.WinCases(); // Кейсы победы, ничьи и поражения
            Input.UserInputs();// Ввод игрока
            Ai.EasyBot();
        }
    }
}