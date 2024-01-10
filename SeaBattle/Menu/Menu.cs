namespace SeaBattle.Menu;

public class Menu
{
    public static void ShowMenu()
    {
        while (true)
        {
            MenuHelper.Greeting();

            Console.Write(
                "1. ’start’ (or ‘s’) - start the game.\r\n" +
                "2. ’help’ (or ‘h’) - show game rules.\r\n" +
                "3. ‘quit’ (or ‘q’) - quit the game.\r\n" +
                ">");
            Console.ResetColor();
            Console.CursorVisible = true;

            string userInput = Console.ReadLine().ToLower().Trim();

            if (userInput == "start" || userInput == "s")
            {
                MenuCommands.StartGame();
            }
            else if (userInput == "help" || userInput == "h")
            {
                MenuCommands.MenuInstructions();
            }
            else if (userInput == "quit" || userInput == "q")
            {
                MenuCommands.ExitGame();
            }
            else
            {
                MenuHelper.WrongInputValidation();
            }
        }
    }
}