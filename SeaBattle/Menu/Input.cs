using static SeaBattle.Graphics.Board;
namespace SeaBattle.Menu
{
    public static class Input
    {
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
                    else if (enemyCells[index - 1, index2 - 1] == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You've already attacked here, please choose another cell.");
                        Console.ResetColor();
                    }
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
