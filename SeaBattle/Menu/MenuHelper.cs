namespace SeaBattle.Menu;

public static class MenuHelper
{
    public static void Greeting()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Welcome to The Sea Battle game.");

        DrawHorizontalLine();
    }

    public static void DrawHorizontalLine()
    {
        for (int i = 0; i < Console.BufferWidth; i++)
        {
            Console.Write('=');
        }
    }

    public static void DrawCoordinates()
    {
        for (int i = 1; i < 11; i++)
        {
            Console.Write(i + " ");
        }
    }

    public static void WrongInputValidation()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("There is no such command, please try another command.");
        Console.ResetColor();
        Console.CursorVisible = false;

        Task.Delay(2000).Wait();

    }

    public static void CellIsTaken()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("This cell is taken, please choose another cell.");
        Console.ResetColor();
        Console.CursorVisible = false;

        Task.Delay(2000).Wait();
    }
}
