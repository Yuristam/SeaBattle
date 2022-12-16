/*using SeaBattle.Content;
using SeaBattle.Menu;

namespace SeaBattle.Input
{
    internal class SecondLineInputs
    {


        Menu.Menu menu = new Menu.Menu();
        public void UserInput()
        {
            while (true)
            {
                string userInput = ReadLine().ToLower().Trim().Replace(" ", "");

                if (userInput == "12")
                {
                    if (Board.secondLineCells[0] == " ~")
                    {
                        Board.secondLineCells[0] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.secondLineCells[0] == " O")
                    {
                        Board.secondLineCells[0] = " X";    // got the ship
                    }
                    else if (Board.secondLineCells[0] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "22")
                {
                    if (Board.secondLineCells[1] == " ~")
                    {
                        Board.secondLineCells[1] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.secondLineCells[1] == " O")
                    {
                        Board.secondLineCells[1] = " X";    // got the ship
                    }
                    else if (Board.secondLineCells[1] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "32")
                {
                    if (Board.secondLineCells[2] == " ~")
                    {
                        Board.secondLineCells[2] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.secondLineCells[2] == " O")
                    {
                        Board.secondLineCells[2] = " X";    // got the ship
                    }
                    else if (Board.secondLineCells[2] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "42")
                {
                    if (Board.secondLineCells[3] == " ~")
                    {
                        Board.secondLineCells[3] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.secondLineCells[3] == " O")
                    {
                        Board.secondLineCells[3] = " X";    // got the ship
                    }
                    else if (Board.secondLineCells[3] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "52")
                {
                    if (Board.secondLineCells[4] == " ~")
                    {
                        Board.secondLineCells[4] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.secondLineCells[4] == " O")
                    {
                        Board.secondLineCells[4] = " X";    // got the ship
                    }
                    else if (Board.secondLineCells[4] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "62")
                {
                    if (Board.secondLineCells[5] == " ~")
                    {
                        Board.secondLineCells[5] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.secondLineCells[5] == " O")
                    {
                        Board.secondLineCells[5] = " X";    // got the ship
                    }
                    else if (Board.secondLineCells[5] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "72")
                {
                    if (Board.secondLineCells[6] == " ~")
                    {
                        Board.secondLineCells[6] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.secondLineCells[6] == " O")
                    {
                        Board.secondLineCells[6] = " X";    // got the ship
                    }
                    else if (Board.secondLineCells[6] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "82")
                {
                    if (Board.secondLineCells[7] == " ~")
                    {
                        Board.secondLineCells[7] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.secondLineCells[7] == " O")
                    {
                        Board.secondLineCells[7] = " X";    // got the ship
                    }
                    else if (Board.secondLineCells[7] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "92")
                {
                    if (Board.secondLineCells[8] == " ~")
                    {
                        Board.secondLineCells[8] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.secondLineCells[8] == " O")
                    {
                        Board.secondLineCells[8] = " X";    // got the ship
                    }
                    else if (Board.secondLineCells[8] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "102")
                {
                    if (Board.secondLineCells[9] == " ~")
                    {
                        Board.secondLineCells[9] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.secondLineCells[9] == " O")
                    {
                        Board.secondLineCells[9] = " X";    // got the ship
                    }
                    else if (Board.secondLineCells[9] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }







                else if (userInput == "help" || userInput == "h")
                {
                    menu.ShowHelp();
                }
                else if (userInput == "quit" || userInput == "q")
                {
                    menu.ExitGame();
                }
                else
                {
                    WriteLine("There is no such command, please try another command.");
                    Write('>');
                }
            }
        }
    }
}
*/