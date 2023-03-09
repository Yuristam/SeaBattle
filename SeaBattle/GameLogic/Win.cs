using static SeaBattle.Graphics.Board;
namespace SeaBattle.GameLogic
{
    internal static class Win
    {
        //todo input кораблей сюда в win class-е

        /*public static void WinCheck()
        {
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                enemyCells[random.Next(0, 10), random.Next(0, 10)] = '#';
            }
        }*/
        public static Random random = new Random();
        public static int shipX1 = random.Next(0, 3);
        public static int shipX2 = random.Next(3, 5);
        public static int shipX3 = random.Next(6, 8);
        public static int shipY1 = random.Next(0, 3);
        public static int shipY2 = random.Next(3, 4);
        public static int shipY3 = random.Next(8, 9);
/*
        enemyCells[shipX1, shipY1] ='#';*/

        public static void WinCases()
        {

           // enemyCells[shipX1, shipY1] = '#';

            /* enemyCells[shipX, shipY] = '#';*/
            /*
                        if (enemyCells[Win.shipX1, Win.shipY1] == 'X' ||
                            enemyCells[Win.shipX2, Win.shipY2] == 'X' ||
                            enemyCells[Win.shipX3, Win.shipY3] == 'X')
                        {


                        }*/

            if (enemyCells[shipX1, shipY1] == 'O' &&
                enemyCells[shipX2, shipY2] == 'O' &&
                enemyCells[shipX3, shipY3] == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win!");
                Console.ResetColor();
                Task t = Task.Delay(2000);
                t.Wait();
                Console.Clear();
                Environment.Exit(0);
            }
            // todo ввод кораблей игрока вместо индексов
            //                   i  j
            else if (playerCells[0, 0] == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose.");
                Console.ResetColor();
                Task t = Task.Delay(2000);
                t.Wait();
                Console.Clear();
                Environment.Exit(0);
            }
            //enemyCells[shipX,shipY] = '#';

        }
    }
}