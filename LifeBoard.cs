using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameOfLife
{
    public class LifeBoard
    {
        bool[,] Grid;
        
        public int Rows = 10;
        public int Columns = 10;

        public LifeBoard()
        {
            Grid = new bool[Rows, Columns];
        }

        public void PrintBoard()
        {
            for (int b = 0; b < Rows; b++)
            {
                for (int e = 2; e < Columns; e++)
                {
                    Console.Write(Grid[b, e]);
                }
                Console.WriteLine();
            }
        }

        public void ClearBoard()
        {

            Console.Clear();
        }

        public void CountBoard()
        {
            int totalCount = 0 + 1;
            totalCount++;

            foreach (var rows in Grid)
          foreach (var col in Grid)

           
            Console.WriteLine(totalCount);

        }

    }
}