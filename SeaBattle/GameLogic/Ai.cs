using static SeaBattle.Graphics.Board;
namespace SeaBattle.GameLogic
{
    public class Ai
    {
        internal static void EasyBot()
        {
            Random random = new();
            Random random2 = new();
            while (true)
            {
                int index = random.Next(0, 10);
                int index2 = random2.Next(0, 10);

                if (playerCells[index, index2] == 'X' || playerCells[index, index2] == 'O')
                {
                    random.Next(0, 9);
                    random2.Next(0, 9);
                }
                else if(playerCells[index, index2] == '#')
                {
                    playerCells[index, index2] = 'O';
                    //comp shot your ship
                    break;
                }
                else
                {
                    playerCells[index, index2] = 'X';
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Computer has chosen [ {index + 1} : {index2 + 1} ], so it's your turn now");
                    Console.ResetColor();
                    Task t = Task.Delay(2000);
                    t.Wait();
                    break;
                }
            }
        }
    }
}
