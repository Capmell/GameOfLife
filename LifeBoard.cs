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

        int r;
        int c;




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

            // also tried this statement below thats commented it supposedly cleans out both the console and any leftover memory of the info stored but I could not get it to work the way I wanted to

            //Console.Clear();
            //Console.WriteLine("\x1b[3J");


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

        public int CountAliveNeighbors()
        {
            int count = 0;

     
            for (int r = -1; r <= 1; r++)
            {
                for (int c = -1; c <= 1; c++)
                {

                    if (r == 10 && c == 10) ;

                    int neighborRow = Rows + r;
                    int neighborCol = Columns + c;

                  
                    if (neighborRow >= 0 && neighborRow < Rows &&
                        neighborCol >= 0 && neighborCol < Columns)
                    {
                        if (Grid[neighborRow, neighborCol])
                        {
                            Grid[r, c] = true;
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
            return count;
         
        }

        // might need to tweak the code here im not sure
        public void AdvanceGeneration()
        {
    bool[,] nextGeneration = new bool[Rows, Columns];

    for (int r = 0; r < Rows; r++)
    {
        for (int c = 0; c < Columns; c++)
        {
            int neighbors = CountAliveNeighbors2(r, c);
            bool isAlive = Grid[r, c];

            // Apply Conway's Rules
            if (isAlive && (neighbors == 2 || neighbors == 3))
            {
                nextGeneration[r, c] = true; 
            }
            else if (!isAlive && neighbors == 3)
            {
                nextGeneration[r, c] = true; 
            }
            else
            {
                nextGeneration[r, c] = false; 
            }

          
                    Console.WriteLine(neighbors);
                    Console.WriteLine(isAlive);
                }
    }


    Grid = nextGeneration;

           
}
        // this extra was made simply because of could not implement COuntALiveNeighbors twice so I made a dulplicate 
        private int CountAliveNeighbors2(int r, int c)
        {
            int count = 0;


            for (int t = -1; t <= 1; t++)
            {
                for (int d = -1; d <= 1; d++)
                {

                    if (t == 10 && d == 10) ;

                    int neighborRow = r + t;
                    int neighborCol = c + d;


                    if (neighborRow >= 0 && neighborRow < Rows &&
                        neighborCol >= 0 && neighborCol < Columns)
                    {
                        if (Grid[neighborRow, neighborCol])
                        {
                            Grid[r, c] = true;
                            count++;
                        }
                    }
                }
            }
        
            return count;
        }
    }
}