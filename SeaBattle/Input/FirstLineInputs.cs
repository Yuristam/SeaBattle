/*using SeaBattle.Content;
using SeaBattle.Menu;

namespace SeaBattle.Input
{
    internal class FirstLineInputs
    {

        Menu.Menu menu = new Menu.Menu();
        public void UserInput()
        {
            while (true)
            {
                string userInput = ReadLine().ToLower().Trim().Replace(" ", "");

                switch (Board.firstLineCells[0])
                {
                    case " ~":
                        Board.firstLineCells[0] = " w";
                break;
                }



    *//*
                    if (userInput == "11")
                    {
                        if (GameBoard.firstLineCells[0] == " ~")
                        {
                            GameBoard.firstLineCells[0] = " w";    // empty sea cell
                            break;
                        }
                        else if (GameBoard.firstLineCells[0] == " O")
                        {
                            GameBoard.firstLineCells[0] = " X";    // got the ship
                        }
                        else if (GameBoard.firstLineCells[0] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                        {
                            WriteLine("You can't attack here, please choose another cell.");
                            Write('>');
                        }
                    }*//*
                    if (userInput == "21")
                    {
                        if (Board.firstLineCells[1] == " ~")
                        {
                            Board.firstLineCells[1] = " w";    // empty sea cell
                            break;
                        }
                        else if (Board.firstLineCells[1] == " O")
                        {
                            Board.firstLineCells[1] = " X";    // got the ship
                        }
                        else if (Board.firstLineCells[1] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                        {
                            WriteLine("You can't attack here, please choose another cell.");
                            Write('>');
                        }
                    }
                    if (userInput == "31")
                    {
                        if (Board.firstLineCells[2] == " ~")
                        {
                            Board.firstLineCells[2] = " w";    // empty sea cell
                            break;
                        }
                        else if (Board.firstLineCells[2] == " O")
                        {
                            Board.firstLineCells[2] = " X";    // got the ship
                        }
                        else if (Board.firstLineCells[2] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                        {
                            WriteLine("You can't attack here, please choose another cell.");
                            Write('>');
                        }
                    }
                    if (userInput == "41")
                    {
                        if (Board.firstLineCells[3] == " ~")
                        {
                            Board.firstLineCells[3] = " w";    // empty sea cell
                            break;
                        }
                        else if (Board.firstLineCells[3] == " O")
                        {
                            Board.firstLineCells[3] = " X";    // got the ship
                        }
                        else if (Board.firstLineCells[3] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                        {
                            WriteLine("You can't attack here, please choose another cell.");
                            Write('>');
                        }
                    }
                    if (userInput == "51")
                    {
                        if (Board.firstLineCells[4] == " ~")
                        {
                            Board.firstLineCells[4] = " w";    // empty sea cell
                            break;
                        }
                        else if (Board.firstLineCells[4] == " O")
                        {
                            Board.firstLineCells[4] = " X";    // got the ship
                        }
                        else if (Board.firstLineCells[4] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                        {
                            WriteLine("You can't attack here, please choose another cell.");
                            Write('>');
                        }
                    }
                    if (userInput == "61")
                    {
                        if (Board.firstLineCells[5] == " ~")
                        {
                            Board.firstLineCells[5] = " w";    // empty sea cell
                            break;
                        }
                        else if (Board.firstLineCells[5] == " O")
                        {
                            Board.firstLineCells[5] = " X";    // got the ship
                        }
                        else if (Board.firstLineCells[5] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                        {
                            WriteLine("You can't attack here, please choose another cell.");
                            Write('>');
                        }
                    }
                    if (userInput == "71")
                    {
                        if (Board.firstLineCells[6] == " ~")
                        {
                            Board.firstLineCells[6] = " w";    // empty sea cell
                            break;
                        }
                        else if (Board.firstLineCells[6] == " O")
                        {
                            Board.firstLineCells[6] = " X";    // got the ship
                        }
                        else if (Board.firstLineCells[6] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                        {
                            WriteLine("You can't attack here, please choose another cell.");
                            Write('>');
                        }
                    }
                    if (userInput == "81")
                    {
                        if (Board.firstLineCells[7] == " ~")
                        {
                            Board.firstLineCells[7] = " w";    // empty sea cell
                            break;
                        }
                        else if (Board.firstLineCells[7] == " O")
                        {
                            Board.firstLineCells[7] = " X";    // got the ship
                        }
                        else if (Board.firstLineCells[7] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                        {
                            WriteLine("You can't attack here, please choose another cell.");
                            Write('>');
                        }
                    }
                    if (userInput == "91")
                    {
                        if (Board.firstLineCells[8] == " ~")
                        {
                            Board.firstLineCells[8] = " w";    // empty sea cell
                            break;
                        }
                        else if (Board.firstLineCells[8] == " O")
                        {
                            Board.firstLineCells[8] = " X";    // got the ship
                        }
                        else if (Board.firstLineCells[8] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                        {
                            WriteLine("You can't attack here, please choose another cell.");
                            Write('>');
                        }
                    }
                    if (userInput == "101")
                    {
                        if (Board.firstLineCells[9] == " ~")
                        {
                            Board.firstLineCells[9] = " w";    // empty sea cell
                            break;
                        }
                        else if (Board.firstLineCells[9] == " O")
                        {
                            Board.firstLineCells[9] = " X";    // got the ship
                        }
                        else if (Board.firstLineCells[9] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
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