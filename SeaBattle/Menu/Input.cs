using SeaBattle.GameLogic;
using static SeaBattle.Graphics.Board;

namespace SeaBattle.Menu;
public static class Input
{
    public static Random random = new Random();

    public static int shipX1 = random.Next(0, 10);
    public static int shipX2 = random.Next(0, 10);
    public static int shipX3 = random.Next(0, 10);
    public static int shipX4 = random.Next(0, 10);
    public static int shipX5 = random.Next(0, 10);

    public static int shipY1 = random.Next(0, 10);
    public static int shipY2 = random.Next(0, 10);
    public static int shipY3 = random.Next(0, 10);
    public static int shipY4 = random.Next(0, 10);
    public static int shipY5 = random.Next(0, 10);

    public static void UserShips()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("You have 5 one-cell ships. Now you need to put them in the sea(map below).\r\n" +
            "You can put them close to each other.");
        for (int i = 0; i < Console.BufferWidth; i++)
        {
            Console.Write('=');
        }
        Console.WriteLine("\n");

        for (int k = 1; k < 11; k++)
        {
            Console.Write(k + " ");
        }
        Console.WriteLine();

        for (int k = 0; k < playerCells.GetLength(0); k++)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int j = 0; j < playerCells.GetLength(1); j++)
            {
                if (playerCells[k, j] == '#')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.Write(playerCells[k, j] + " ");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(k + 1);
        }
        //===========================================================================

        while (true)
        {
            Console.Write("Choose your ships.\n");
            Console.Write("Enter the row\n>");
            string userInput = Console.ReadLine().ToLower().Trim();
            Console.Write("Enter the column\n>");
            string userInput2 = Console.ReadLine().ToLower().Trim();
            //==========================================================================
            if (int.TryParse(userInput, out int index) && int.TryParse(userInput2, out int index2))
            {
                if (index <= 0 || index > 10 || index2 <= 0 || index2 > 10)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("There is no such command, please try another command.\n>");
                    Console.ResetColor();
                }
                else if (playerCells[index - 1, index2 - 1] == '#')
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You've already chosen this cells, please choose another cell.");
                    Console.ResetColor();
                }
                else
                {
                    playerCells[index - 1, index2 - 1] = '#';
                    break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("There is no such command, please try another command.\n>");
                Console.ResetColor();
            }
        }
    }
    public static void UserInputs()
    {
        while (true)
        {
            Console.Write("Enter the row\n>");
            string userInput = Console.ReadLine().ToLower().Trim();
            Console.Write("Enter the column\n>");
            string userInput2 = Console.ReadLine().ToLower().Trim();
            //==========================================================================
            if (int.TryParse(userInput, out int index) && int.TryParse(userInput2, out int index2))
            {
                if (index <= 0 || index > 10 || index2 <= 0 || index2 > 10)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("There is no such command, please try another command.\n>");
                    Console.ResetColor();
                }
                else if (enemyCells[index - 1, index2 - 1] == 'X' || enemyCells[index - 1, index2 - 1] == '*')
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You've already attacked here, please choose another cell.");
                    Console.ResetColor();
                }
                //=============================================================================
                else if (index - 1 == shipX1 && index2 - 1 == shipY1)
                {
                    enemyCells[shipX1, shipY1] = '*';
                    enemyShips--;
                    break;
                }
                else if (index - 1 == shipX2 && index2 - 1 == shipY2)
                {
                    enemyCells[shipX2, shipY2] = '*';
                    enemyShips--;
                    break;
                }
                else if (index - 1 == shipX3 && index2 - 1 == shipY3)
                {
                    enemyCells[shipX3, shipY3] = '*';
                    enemyShips--;
                    break;
                }
                else if (index - 1 == shipX4 && index2 - 1 == shipY4)
                {
                    enemyCells[shipX4, shipY4] = '*';
                    enemyShips--;
                    break;
                }
                else if (index - 1 == shipX5 && index2 - 1 == shipY5)
                {
                    enemyCells[shipX5, shipY5] = '*';
                    enemyShips--;
                    break;
                }
                //========================================================================================
                else
                {
                    enemyCells[index - 1, index2 - 1] = 'X';
                    break;
                }
            }
            //==========================================================================
            else if (userInput == "quit" || userInput == "q")
            {
                Menu.ExitGame();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("There is no such command, please try another command.\n>");
                Console.ResetColor();
            }
        }
    }
}