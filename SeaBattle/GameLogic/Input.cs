using SeaBattle.GameElements;
using SeaBattle.Menu;
using static SeaBattle.GameElements.Board;
using static SeaBattle.GameElements.Ship;

namespace SeaBattle.GameLogic;

public class Input
{
    public static void UserShips()
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("You have 5 one-cell ships. Now you need to put them into the sea(map below).\r\n" +
            "You can put them close to each other ;)");

            MenuHelper.DrawHorizontalLine();
            MenuHelper.DrawCoordinates();

            Console.WriteLine();

            DrawExistingUserShips();

            Console.Write("Choose your ships.\n");

            Console.Write("Enter the row\n>");
            string userInput = Console.ReadLine().ToLower().Trim();
            Console.Write("Enter the column\n>");
            string userInput2 = Console.ReadLine().ToLower().Trim();

            if (int.TryParse(userInput, out int index) && int.TryParse(userInput2, out int index2))
            {
                if (index <= 0 || index > 10 || index2 <= 0 || index2 > 10)
                {
                    MenuHelper.WrongInputValidation();
                }
                else if (PlayerCells[index - 1, index2 - 1] == '#')
                {
                    MenuHelper.CellIsTaken();
                }
                else
                {
                    PlayerCells[index - 1, index2 - 1] = '#';
                    break;
                }
            }

            else if (userInput == "m" || userInput == "menu")
            {
                Menu.Menu.ShowMenu();
            }

            else
            {
                MenuHelper.WrongInputValidation();
            }
        }
    }

    public static void DrawExistingUserShips()
    {
        for (int i = 0; i < PlayerCells.GetLength(0); i++)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;

            for (int j = 0; j < PlayerCells.GetLength(1); j++)
            {
                if (PlayerCells[i, j] == '#')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.Write(PlayerCells[i, j] + " ");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(i + 1);
        }
    }

    public static void UserInputs()
    {
        while (true)
        {
            Console.CursorVisible = true;

            Console.Write("Enter the row\n>");
            string userInput = Console.ReadLine().ToLower().Trim();
            Console.Write("Enter the column\n>");
            string userInput2 = Console.ReadLine().ToLower().Trim();

            if (int.TryParse(userInput, out int index) && int.TryParse(userInput2, out int index2))
            {
                if (index <= 0 || index > 10 || index2 <= 0 || index2 > 10)
                {
                    Console.SetCursorPosition(60, 4);
                    MenuHelper.WrongInputValidation();

                    Board board = new Board();
                    board.DrawBoard();
                }
                else if (EnemyCells[index - 1, index2 - 1] == 'X' || EnemyCells[index - 1, index2 - 1] == '*')
                {
                    Console.SetCursorPosition(60, 4);
                    MenuHelper.CellIsTaken();
                    
                    Board board = new Board();
                    board.DrawBoard();
                }

                else if (index - 1 == shipX1 && index2 - 1 == shipY1)
                {
                    EnemyCells[shipX1, shipY1] = '*';
                    EnemyShips--;
                    //Console.Beep(200,100);
                    break;
                }
                else if (index - 1 == shipX2 && index2 - 1 == shipY2)
                {
                    EnemyCells[shipX2, shipY2] = '*';
                    EnemyShips--;
                    break;
                }
                else if (index - 1 == shipX3 && index2 - 1 == shipY3)
                {
                    EnemyCells[shipX3, shipY3] = '*';
                    EnemyShips--;
                    break;
                }
                else if (index - 1 == shipX4 && index2 - 1 == shipY4) 
                {
                    EnemyCells[shipX4, shipY4] = '*';
                    EnemyShips--;
                    break;
                }
                else if (index - 1 == shipX5 && index2 - 1 == shipY5)
                {
                    EnemyCells[shipX5, shipY5] = '*';
                    EnemyShips--;
                    break;
                }
                else
                {
                    EnemyCells[index - 1, index2 - 1] = 'X';
                    break;
                }
            }

            else if (userInput == "m" || userInput == "mainmenu")
            {
                Menu.Menu.ShowMenu();
            }

            else
            {
                Console.SetCursorPosition(60, 4);
                MenuHelper.WrongInputValidation();

                Board board = new Board();
                board.DrawBoard();
            }
        }
    }
}
