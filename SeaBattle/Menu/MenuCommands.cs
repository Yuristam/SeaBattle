using SeaBattle.GameElements;

namespace SeaBattle.Menu;

public static class MenuCommands
{
    public static void StartGame()
    {
        BoardHelper.FillBoardWithEmptyWaves(Board.PlayerCells);
        BoardHelper.FillBoardWithEmptyWaves(Board.EnemyCells);

        BoardHelper.PutPlayerShips();
        Ship.RandomShipGenerator();

        Board.PlayerShips = 5;
        Board.EnemyShips = 5;

        Board board = new Board();
        board.DrawBoard();
    }

    public static void MenuInstructions()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Clear();
        Console.WriteLine("RULES OF THE GAME\n\n" +
            "Battleship or Sea Battle is a war-themed board game for two players in which\r\n" +
            "the opponents try to guess the location of their opponent's warships and sink them.\r\n" +
            "The gameplay is straightforward. Each player hides ships on a grid containing vertical and\r\n" +
            "horizontal space coordinates. Players take turns calling out row and column coordinates on\r\n" +
            "the other player's grid in an attempt to identify a square that contains a ship.\r\n" +
            "The game board each player gets has two grids: an upper and lower grid.\r\n" +
            "The lower grid is used by the player to \"hide\" the location of his own ships,\r\n" +
            "while the upper grid is used to record the shots fired toward the opponent and to document\r\n" +
            "whether those shots were hits or misses.");
        Console.ReadKey();
        Console.ResetColor();
    }

    public static void ExitGame()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Good Bye!");

        Environment.Exit(0);
    }
}