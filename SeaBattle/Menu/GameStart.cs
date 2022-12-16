using SeaBattle.Content;
using SeaBattle.Input;

namespace SeaBattle.Menu
{
    public class GameStart
    {
        Board board = new Board();
        public void Start()
        {
            while (true)
            {
                board.DrawBoard();


                Inputs userInput = new Inputs();
                userInput.UserInput();
            }
        }
    }
}
