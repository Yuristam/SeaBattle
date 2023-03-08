using SeaBattle.GameLogic;
using SeaBattle.Menu;

namespace SeaBattle.Graphics;
public class Board
{
    public static char[,] playerCells = new char[10, 10];
    public static char[,] enemyCells = new char[10, 10];

    public void DrawBoard()
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
        //рандомные корабли врага
        Random random = new Random();
        for (int i = 0; i < 3; i++)
        {
            enemyCells[random.Next(0, 10), random.Next(0, 10)] = '#';
        }
        //====================================================================================
        while (true)
        {
            Console.Clear();

            // Player's 1 2 3 4 5 6 7 8 9 0
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
                    if (enemyCells[i, j] == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
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
            /*for (int k = 1; k < 11; k++)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < playerCells.GetLength(0); i++)
            {
                for (int j = 0; j < playerCells.GetLength(1); j++)
                {
                    Console.Write(playerCells[i, j] + " ");
                }
                Console.WriteLine(i + 1);
            }*/
            //===================================================================================

            for (int i = 0; i < Console.BufferWidth; i++)
            {
                Console.Write('=');
            }
            Input.UserInputs();// Ввод игрока
            Win.WinCases(); // Кейсы победы, ничьи и поражения
            Ai.EasyBot();
            Win.WinCases(); // Кейсы победы, ничьи и поражения
        }
    }
}