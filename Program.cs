using System.Linq.Expressions;

namespace GameOfLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // i need to change some things for sure is there anything that stands out to you?
            //GOAL clean up code at some point so its not as long
            LifeBoard printBoard = new LifeBoard();

            printBoard.PrintBoard();

          



            LifeBoard nextinput = new LifeBoard();

            nextinput.NextInput();

            LifeBoard countBoard = new LifeBoard();

            countBoard.CountAliveNeighbors();

            LifeBoard nextinput3 = new LifeBoard();

            nextinput.NextInput();

            LifeBoard advance = new LifeBoard();

            advance.Rules();

           

            LifeBoard nextinput2 = new LifeBoard();

            nextinput.NextInput();

            LifeBoard clearBoard = new LifeBoard();

            clearBoard.ClearBoard();

            LifeBoard nextinput4 = new LifeBoard();

            nextinput.NextInput();

            LifeBoard printBoard2 = new LifeBoard();

            printBoard.PrintBoard();

            LifeBoard countBoard2 = new LifeBoard();

            countBoard.CountAliveNeighbors();

            LifeBoard nextinput7 = new LifeBoard();

            nextinput.NextInput();

            LifeBoard advance2 = new LifeBoard();

            advance.Rules();



            LifeBoard nextinput5 = new LifeBoard();

            nextinput.NextInput();


            LifeBoard clearBoard2 = new LifeBoard();

            clearBoard.ClearBoard();

            LifeBoard nextinput6 = new LifeBoard();

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
