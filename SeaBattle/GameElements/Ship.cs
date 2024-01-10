namespace SeaBattle.GameElements;

public class Ship
{
    private static Random _random = new Random();

    public static int shipX1;
    public static int shipX2;
    public static int shipX3;
    public static int shipX4;
    public static int shipX5;

    public static int shipY1;
    public static int shipY2;
    public static int shipY3;
    public static int shipY4;
    public static int shipY5;

    public static void RandomShipGenerator()
    {
        while (shipX1 == shipX2 || shipX1 == shipX3 || shipX1 == shipX4 || shipX1 == shipX5
            || shipX2 == shipX3 || shipX2 == shipX4 || shipX2 == shipX5
            || shipX3 == shipX4 || shipX3 == shipX5
            || shipX4 == shipX5)
        {
            shipX1 = _random.Next(0, 10);
            shipX2 = _random.Next(0, 10);
            shipX3 = _random.Next(0, 10);
            shipX4 = _random.Next(0, 10);
            shipX5 = _random.Next(0, 10);

            shipY1 = _random.Next(0, 10);
            shipY2 = _random.Next(0, 10);
            shipY3 = _random.Next(0, 10);
            shipY4 = _random.Next(0, 10);
            shipY5 = _random.Next(0, 10);
        }
    }
}