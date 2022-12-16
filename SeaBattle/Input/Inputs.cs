using SeaBattle.Content;

namespace SeaBattle.Input
{
    public class Inputs
    {
        Menu.Menu menu = new Menu.Menu();
        public void UserInput()
        {
            while (true)
            {
                string userInput = ReadLine().ToLower().Trim().Replace(" ", "");



                // firstLine



                if (userInput == "11")
                {
                    if (Board.firstLineCells[0] == " ~")
                    {
                        Board.firstLineCells[0] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.firstLineCells[0] == " O")
                    {
                        Board.firstLineCells[0] = " X";    // got the ship
                    }
                    else if (Board.firstLineCells[0] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
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




                // secondLine





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





                // thirdLine


                if (userInput == "13")
                {
                    if (Board.thirdLineCells[0] == " ~")
                    {
                        Board.thirdLineCells[0] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.thirdLineCells[0] == " O")
                    {
                        Board.thirdLineCells[0] = " X";    // got the ship
                    }
                    else if (Board.thirdLineCells[0] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "23")
                {
                    if (Board.thirdLineCells[1] == " ~")
                    {
                        Board.thirdLineCells[1] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.thirdLineCells[1] == " O")
                    {
                        Board.thirdLineCells[1] = " X";    // got the ship
                    }
                    else if (Board.thirdLineCells[1] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "33")
                {
                    if (Board.thirdLineCells[2] == " ~")
                    {
                        Board.thirdLineCells[2] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.thirdLineCells[2] == " O")
                    {
                        Board.thirdLineCells[2] = " X";    // got the ship
                    }
                    else if (Board.thirdLineCells[2] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "43")
                {
                    if (Board.thirdLineCells[3] == " ~")
                    {
                        Board.thirdLineCells[3] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.thirdLineCells[3] == " O")
                    {
                        Board.thirdLineCells[3] = " X";    // got the ship
                    }
                    else if (Board.thirdLineCells[3] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "53")
                {
                    if (Board.thirdLineCells[4] == " ~")
                    {
                        Board.thirdLineCells[4] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.thirdLineCells[4] == " O")
                    {
                        Board.thirdLineCells[4] = " X";    // got the ship
                    }
                    else if (Board.thirdLineCells[4] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "63")
                {
                    if (Board.thirdLineCells[5] == " ~")
                    {
                        Board.thirdLineCells[5] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.thirdLineCells[5] == " O")
                    {
                        Board.thirdLineCells[5] = " X";    // got the ship
                    }
                    else if (Board.thirdLineCells[5] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "73")
                {
                    if (Board.thirdLineCells[6] == " ~")
                    {
                        Board.thirdLineCells[6] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.thirdLineCells[6] == " O")
                    {
                        Board.thirdLineCells[6] = " X";    // got the ship
                    }
                    else if (Board.thirdLineCells[6] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "83")
                {
                    if (Board.thirdLineCells[7] == " ~")
                    {
                        Board.thirdLineCells[7] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.thirdLineCells[7] == " O")
                    {
                        Board.thirdLineCells[7] = " X";    // got the ship
                    }
                    else if (Board.thirdLineCells[7] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "93")
                {
                    if (Board.thirdLineCells[8] == " ~")
                    {
                        Board.thirdLineCells[8] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.thirdLineCells[8] == " O")
                    {
                        Board.thirdLineCells[8] = " X";    // got the ship
                    }
                    else if (Board.thirdLineCells[8] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "103")
                {
                    if (Board.thirdLineCells[9] == " ~")
                    {
                        Board.thirdLineCells[9] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.thirdLineCells[9] == " O")
                    {
                        Board.thirdLineCells[9] = " X";    // got the ship
                    }
                    else if (Board.thirdLineCells[9] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }





                // forth











                if (userInput == "14")
                {
                    if (Board.forthLineCells[0] == " ~")
                    {
                        Board.forthLineCells[0] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.forthLineCells[0] == " O")
                    {
                        Board.forthLineCells[0] = " X";    // got the ship
                    }
                    else if (Board.forthLineCells[0] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "24")
                {
                    if (Board.forthLineCells[1] == " ~")
                    {
                        Board.forthLineCells[1] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.forthLineCells[1] == " O")
                    {
                        Board.forthLineCells[1] = " X";    // got the ship
                    }
                    else if (Board.forthLineCells[1] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "34")
                {
                    if (Board.forthLineCells[2] == " ~")
                    {
                        Board.forthLineCells[2] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.forthLineCells[2] == " O")
                    {
                        Board.forthLineCells[2] = " X";    // got the ship
                    }
                    else if (Board.forthLineCells[2] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "44")
                {
                    if (Board.forthLineCells[3] == " ~")
                    {
                        Board.forthLineCells[3] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.forthLineCells[3] == " O")
                    {
                        Board.forthLineCells[3] = " X";    // got the ship
                    }
                    else if (Board.forthLineCells[3] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "54")
                {
                    if (Board.forthLineCells[4] == " ~")
                    {
                        Board.forthLineCells[4] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.forthLineCells[4] == " O")
                    {
                        Board.forthLineCells[4] = " X";    // got the ship
                    }
                    else if (Board.forthLineCells[4] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "64")
                {
                    if (Board.forthLineCells[5] == " ~")
                    {
                        Board.forthLineCells[5] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.forthLineCells[5] == " O")
                    {
                        Board.forthLineCells[5] = " X";    // got the ship
                    }
                    else if (Board.forthLineCells[5] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "74")
                {
                    if (Board.forthLineCells[6] == " ~")
                    {
                        Board.forthLineCells[6] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.forthLineCells[6] == " O")
                    {
                        Board.forthLineCells[6] = " X";    // got the ship
                    }
                    else if (Board.forthLineCells[6] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "84")
                {
                    if (Board.forthLineCells[7] == " ~")
                    {
                        Board.forthLineCells[7] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.forthLineCells[7] == " O")
                    {
                        Board.forthLineCells[7] = " X";    // got the ship
                    }
                    else if (Board.forthLineCells[7] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "94")
                {
                    if (Board.forthLineCells[8] == " ~")
                    {
                        Board.forthLineCells[8] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.forthLineCells[8] == " O")
                    {
                        Board.forthLineCells[8] = " X";    // got the ship
                    }
                    else if (Board.forthLineCells[8] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "104")
                {
                    if (Board.forthLineCells[9] == " ~")
                    {
                        Board.forthLineCells[9] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.forthLineCells[9] == " O")
                    {
                        Board.forthLineCells[9] = " X";    // got the ship
                    }
                    else if (Board.forthLineCells[9] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }




                //fifth








                if (userInput == "15")
                {
                    if (Board.fifthLineCells[0] == " ~")
                    {
                        Board.fifthLineCells[0] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.fifthLineCells[0] == " O")
                    {
                        Board.fifthLineCells[0] = " X";    // got the ship
                    }
                    else if (Board.fifthLineCells[0] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "25")
                {
                    if (Board.fifthLineCells[1] == " ~")
                    {
                        Board.fifthLineCells[1] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.fifthLineCells[1] == " O")
                    {
                        Board.fifthLineCells[1] = " X";    // got the ship
                    }
                    else if (Board.fifthLineCells[1] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "35")
                {
                    if (Board.fifthLineCells[2] == " ~")
                    {
                        Board.fifthLineCells[2] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.fifthLineCells[2] == " O")
                    {
                        Board.fifthLineCells[2] = " X";    // got the ship
                    }
                    else if (Board.fifthLineCells[2] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "45")
                {
                    if (Board.fifthLineCells[3] == " ~")
                    {
                        Board.fifthLineCells[3] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.fifthLineCells[3] == " O")
                    {
                        Board.fifthLineCells[3] = " X";    // got the ship
                    }
                    else if (Board.fifthLineCells[3] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "55")
                {
                    if (Board.fifthLineCells[4] == " ~")
                    {
                        Board.fifthLineCells[4] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.fifthLineCells[4] == " O")
                    {
                        Board.fifthLineCells[4] = " X";    // got the ship
                    }
                    else if (Board.fifthLineCells[4] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "65")
                {
                    if (Board.fifthLineCells[5] == " ~")
                    {
                        Board.fifthLineCells[5] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.fifthLineCells[5] == " O")
                    {
                        Board.fifthLineCells[5] = " X";    // got the ship
                    }
                    else if (Board.fifthLineCells[5] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "75")
                {
                    if (Board.fifthLineCells[6] == " ~")
                    {
                        Board.fifthLineCells[6] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.fifthLineCells[6] == " O")
                    {
                        Board.fifthLineCells[6] = " X";    // got the ship
                    }
                    else if (Board.fifthLineCells[6] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "85")
                {
                    if (Board.fifthLineCells[7] == " ~")
                    {
                        Board.fifthLineCells[7] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.fifthLineCells[7] == " O")
                    {
                        Board.fifthLineCells[7] = " X";    // got the ship
                    }
                    else if (Board.fifthLineCells[7] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "95")
                {
                    if (Board.fifthLineCells[8] == " ~")
                    {
                        Board.fifthLineCells[8] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.fifthLineCells[8] == " O")
                    {
                        Board.fifthLineCells[8] = " X";    // got the ship
                    }
                    else if (Board.fifthLineCells[8] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
                    {
                        WriteLine("You can't attack here, please choose another cell.");
                        Write('>');
                    }
                }
                if (userInput == "105")
                {
                    if (Board.fifthLineCells[9] == " ~")
                    {
                        Board.fifthLineCells[9] = " w";    // empty sea cell
                        break;
                    }
                    else if (Board.fifthLineCells[9] == " O")
                    {
                        Board.fifthLineCells[9] = " X";    // got the ship
                    }
                    else if (Board.fifthLineCells[9] != " ~")   //потом это проверить с помошю cw (или если что GameBoard.firstLineCells[0] != " ~" &&GameBoard.firstLineCells[0] != " O"  )
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
