using System.Linq.Expressions;

namespace GameOfLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LifeBoard printBoard = new LifeBoard();

            printBoard.PrintBoard();

            Console.ReadLine();
            
            LifeBoard countBoard = new LifeBoard();

            countBoard.CountBoard();

            Console.ReadLine();

            LifeBoard clearBoard = new LifeBoard();

            clearBoard.ClearBoard();

            //var choices
            //switch (choices)
            //{
            //    case value1:
            //        // Code to execute if expression equals value1
            //        break;
            //    case value2:
            //        // Code to execute if expression equals value2
            //        break;
            //    default:
            //        // Code to execute if no case matches
            //        break;
            //}
        }
    }
}
