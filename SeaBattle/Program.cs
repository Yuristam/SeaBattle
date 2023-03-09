using static SeaBattle.Menu.Input;
using SeaBattle.Menu;

class Program
{
    static public void Main()
    {
        if (shipX1 != shipX2 && shipX2 != shipX3 && shipX3 != shipX4 && shipX4 != shipX5 &&
            shipX1 != shipX3 && shipX2 != shipX4 && shipX3 != shipX5 &&
            shipX1 != shipX4 && shipX2 != shipX5 &&
            shipX1 != shipX5)
        {
            Menu.ShowMenu();
        }
    }
}