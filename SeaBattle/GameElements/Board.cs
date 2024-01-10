using SeaBattle.GameLogic;
using SeaBattle.Menu;
using static SeaBattle.GameElements.BoardHelper;

namespace SeaBattle.GameElements;

public class Board
{
    public static int EnemyShips { get; set; } = 0;
    public static int PlayerShips { get; set; } = 0;

    public static char[,] PlayerCells { get; set; } = new char[10, 10];
    public static char[,] EnemyCells { get; set; } = new char[10, 10];

    public void DrawBoard()
    {
        while (true)
        {
            DrawCurrentBoardState(PlayerCells);
            DrawCurrentBoardState(EnemyCells);

            DrawMapWithEnemyShips();
            DrawMapWithPlayerShips();

            PrintCurrentGameStatistics();

            Console.SetCursorPosition(0, 12);
            MenuHelper.DrawHorizontalLine();

            Console.SetCursorPosition(0, 13);
            Win.WinCases();

            Console.CursorVisible = true;

            Input.UserInputs();
            Ai.EasyBot();
        }
    }
}