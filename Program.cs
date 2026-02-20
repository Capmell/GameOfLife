using System.Linq.Expressions;

namespace GameOfLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LifeBoard printBoard = new LifeBoard();

            printBoard.PrintBoard();

            Console.WriteLine("Press any key to continue");

            Console.ReadLine();
            
            LifeBoard countBoard = new LifeBoard();

            countBoard.CountBoard();

            Console.WriteLine("Press any key to continue");

            Console.ReadLine();

            LifeBoard clearBoard = new LifeBoard();

            clearBoard.ClearBoard();

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
