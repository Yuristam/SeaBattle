using static SeaBattle.GameElements.Board;

namespace SeaBattle.GameLogic;

public class Ai
{
    public static void EasyBot()
    {
        Random random = new Random();

        while (true)
        {
            int index = random.Next(0, 10);
            int index2 = random.Next(0, 10);

            if (PlayerCells[index, index2] == 'X' || PlayerCells[index, index2] == '*')
            {
                random.Next(0, 9);
                random.Next(0, 9);
            }
            else if (PlayerCells[index, index2] == '#')
            {
                PlayerCells[index, index2] = '*';
                PlayerShips--;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(60, 4);
                Console.WriteLine($"Enemy shot your ship [ {index + 1} : {index2 + 1} ]. It's your turn now");
                Console.ResetColor();
                Console.CursorVisible = false;

                Task.Delay(1000).Wait();

                break;
            }
            else
            {
                PlayerCells[index, index2] = 'X';

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(60, 4);
                Console.WriteLine($"Computer has chosen [ {index + 1} : {index2 + 1} ], so it's your turn now");
                Console.ResetColor();
                Console.CursorVisible = false;

                Task.Delay(1000).Wait();

                break;
            }
        }
    }
}