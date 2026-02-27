using System.Linq.Expressions;

namespace GameOfLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GOAL clean up code at some point so its not as long
            LifeBoard printBoard = new LifeBoard();

            printBoard.PrintBoard();

   

           LifeBoard nextinput = new LifeBoard();

            nextinput.NextInput();

            LifeBoard countBoard = new LifeBoard();

            countBoard.CountBoard();

           

            LifeBoard nextinput2 = new LifeBoard();

            nextinput.NextInput();

            LifeBoard clearBoard = new LifeBoard();

            clearBoard.ClearBoard();

            LifeBoard nextinput3 = new LifeBoard();

            nextinput.NextInput();

            LifeBoard printBoard2 = new LifeBoard();

            printBoard.PrintBoard();

          

            LifeBoard nextinput4 = new LifeBoard();

            nextinput.NextInput();


            LifeBoard clearBoard2 = new LifeBoard();

            clearBoard.ClearBoard();

            LifeBoard nextinput5 = new LifeBoard();

            nextinput.NextInput();

            //var choices
            //switch (choices)
            //{
            //    case print:
            //      
            //        break;
            //    case clear:
            //      
            //        break;
            //    default:
            //      
            //        break;
            //}
        }
    }
}
