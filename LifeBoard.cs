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
        //changed to bool so I can make a true or false depending on if they are alive

        // GOAL if possible add dependency injection to make everything run easier

        bool[,] Grid;
        
        public int Rows = 20;

        public int Columns = 15;

        int CellCount;

        

        public LifeBoard()
        {

            Grid = new bool[Rows, Columns];

            CellCount = 0;

            

        }
        // I first thought that the number of columns that appear depended on that number but it did not so it actually would skip columns instead so thats probably why I thought there was a difference I changed it to 0 so nothing is skipped as far as I remember my thought process at least

        public void PrintBoard()
        {
            for (int b = 0; b < Rows; b++)
            {
                for (int e = 0; e < Columns; e++)
                {
                    Grid[b, e] = true;
                    Console.WriteLine(Grid[b, e]);

                }

                Console.WriteLine();

            }


        }

        public void ClearBoard()
        {
            // this should set the grid to false hopefully deleting it then i put a console.clear to completely clean the console
            //Grid[Rows, Columns] = false;
            Console.Clear();

            for (int b = 0; b < Rows; b++)
            {
                for (int e = 0; e < Columns; e++)
                {
                    Grid[b,e] = false;

                }



            
            }

            Console.Clear();

        }
        // added this so program.cs is all method from LifeBoard.cs
        public void NextInput()
        {
            Console.WriteLine("press any button to continue");
            Console.ReadLine();
        }

        public void CountBoard()
        {
            
            CellCount = Grid.GetLength(0);
            
          

          //  foreach (var rows in Grid)
          //foreach (var columns in Grid)

           
            Console.WriteLine(CellCount);
            Console.WriteLine(Rows);
            Console.WriteLine(Columns);

        }

    }
}