namespace SeaBattle.Content
{
    internal class Board
    {
        // the board of the game. the sea

        public static string[] firstLineCells = new string[10];
        public static string[] secondLineCells = new string[10];
        public static string[] thirdLineCells = new string[10];
        public static string[] forthLineCells = new string[10];
        public static string[] fifthLineCells = new string[10];
        public static string[] sixthLineCells = new string[10];
        public static string[] seventhLineCells = new string[10];
        public static string[] eigthLineCells = new string[10];
        public static string[] ninthLineCells = new string[10];
        public static string[] tenthLineCells = new string[10];

        public void DrawBoard()
        {
            for (int i = 0; i < 10; i++)      //for filling all the array with this symbol
            {
                firstLineCells[i] = " ~";
                secondLineCells[i] = " ~";
                thirdLineCells[i] = " ~";
                forthLineCells[i] = " ~";
                fifthLineCells[i] = " ~";
                sixthLineCells[i] = " ~";
                seventhLineCells[i] = " ~";
                eigthLineCells[i] = " ~";
                ninthLineCells[i] = " ~";
                tenthLineCells[i] = " ~";
            }
            Clear();
            Write(' ');                        // the Abscissa line (the horizontal line)
            for (int i = 1; i < 11; i++)
            {
                Write($" {i}");
            }
            WriteLine();


            for (int i = 0; i < 10; i++)
            {
                Write(i);                                   //for ordinate line (the vertical line)
                Write(firstLineCells[i]);               //
                Write(secondLineCells[i]);               //
                Write(thirdLineCells[i]);               //
                Write(forthLineCells[i]);               //
                Write(fifthLineCells[i]);               //
                Write(sixthLineCells[i]);               //
                Write(seventhLineCells[i]);               //
                Write(eigthLineCells[i]);               //
                Write(ninthLineCells[i]);               //
                Write(tenthLineCells[i]);               //
                WriteLine();
            }
        }
    }
}
            