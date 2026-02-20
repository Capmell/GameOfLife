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
        int[,] Grid;
        
        public int Rows = 10;

        public int Columns = 10;

        int CellCount;

        

        public LifeBoard()
        {

            Grid = new int[Rows, Columns];

            CellCount = 0;

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
            
            CellCount = Grid.GetLength(0);

          //  foreach (var rows in Grid)
          //foreach (var columns in Grid)

           
            Console.WriteLine(CellCount);

        }

    }
}