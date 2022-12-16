using SeaBattle.Content;

namespace SeaBattle.Menu
{
    internal class Menu
    {
        GameStart game=new GameStart();
        public void ShowMenu()
        {
            while (true)
            {
                Clear();
                WriteLine("Welcome to The Sea Battle game. Available commands:");
                WriteLine("1. ’start’ (or ‘s’) - start the game.");
                WriteLine("2. ‘help’ (or ‘h’) - show game rules.");
                WriteLine("3. ‘quit’ (or ‘q’) - quit the game.");
                Write('>');
                string userMenuInput = ReadLine().ToLower().Trim();
                if (userMenuInput == "start" || userMenuInput == "s")
                {
                    game.Start();
                    break;
                }
                else if (userMenuInput == "help" || userMenuInput == "h")
                {
                    ShowHelp();
                }
                else if (userMenuInput == "quit" || userMenuInput == "q")
                {
                    ExitGame();
                }
                else
                {
                    Clear();
                    WriteLine("There is no such command, please try another command.");
                }
            }
        }
        public void ShowHelp()
        {
            Clear();
            WriteLine("RULES OF THE GAME");
            WriteLine("The game is played on a grid that's 3 squares by 3 squares.");
            WriteLine("You are 'X', the computer is 'O'. Players take turns putting their marks in empty squares.");
            WriteLine("The first player to get 3 of her marks in a row (up, down, across, or diagonally) is the winner.");
            WriteLine("When all 9 squares are full, the game is over. If no player has 3 marks in a row, the game ends in a tie.");
            WriteLine("\r\nPress any key to get back.");
            ReadKey();
            Clear();
        }
        public void ExitGame()
        {
            WriteLine("You have quitted the game!");
            Environment.Exit(0);
        }
    }
}
