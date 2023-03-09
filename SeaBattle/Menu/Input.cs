using SeaBattle.GameLogic;
using static SeaBattle.Graphics.Board;
namespace SeaBattle.Menu
{
    public static class Input
    {
        public static void UserShips()
        {
                Console.Clear();
                for (int k = 1; k < 11; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();

                for (int k = 0; k < playerCells.GetLength(0); k++)
                {
                    for (int j = 0; j < playerCells.GetLength(1); j++)
                    {
                        Console.Write(playerCells[k, j] + " ");
                    }
                    Console.WriteLine(k + 1);
                }
                //===========================================================================

            while (true)
            {
                Console.Write("Choose your ships.\n");
                Console.Write("Choose the row\n>");
                string userInput = Console.ReadLine().ToLower().Trim();
                Console.Write("Choose the column\n>");
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
            // TODO  заменить первый индекс на буквы и после сделать 1 инпут
            while (true)
            {
                Console.Write("Choose the row\n>");
                string userInput = Console.ReadLine().ToLower().Trim();
                Console.Write("Choose the column\n>");
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
                    else if (enemyCells[index - 1, index2 - 1] == 'X'|| enemyCells[index - 1, index2 - 1] == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You've already attacked here, please choose another cell.");
                        Console.ResetColor();
                    }
                    //=============================================================================
                    // todo solve problem here
                    else if (index - 1 == Win.shipX1 && index2 - 1 == Win.shipY1)
                    {
                        enemyCells[Win.shipX1, Win.shipY1] = 'O';
                        break;
                    }
                    else if (index - 1 == Win.shipX2 && index2 - 1 == Win.shipY2)
                    {
                        enemyCells[Win.shipX2, Win.shipY2] = 'O';
                        break;
                    }
                    else if (index - 1 == Win.shipX3 && index2 - 1 == Win.shipY3)
                    {
                        enemyCells[Win.shipX3, Win.shipY3] = 'O';
                        break;
                    }
                    //todo loop here
                    //========================================================================================
                    else
                    {
                        enemyCells[index - 1, index2 - 1] = 'X';
                        break;
                    }
                }
                //==========================================================================
                /*else if (userInput == "help" || userInput == "h")
                {
                    GameMenu.GameHelp();
                }
                else if (userInput == "quit" || userInput == "q")
                {
                    GameMenu.ExitGame();
                }*/
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("There is no such command, please try another command.\n>");
                    Console.ResetColor();
                }
            }
        }
    }
}
