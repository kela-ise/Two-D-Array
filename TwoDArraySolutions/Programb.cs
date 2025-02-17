using System;
using System.Drawing;
using Console = Colorful.Console;

namespace TwoDArraySolutions
{
    internal class Programb
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            char[] randomSymbols = { '%', '&', '@', '#', '$' };// characters that will be randomly placed in the grid/array
            Console.WriteLine("2D Array");
            Console.Write("Enter # of Rows: ");
            int numberOfRows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter # of Cols: ");
            int noOfColumns = Convert.ToInt32(Console.ReadLine());
            char[,] playGround = new char[numberOfRows, noOfColumns];// using char because of randomSymbols
            Console.WriteLine($"Your Array has {numberOfRows} rows & {noOfColumns} cols"); // 2d array
            string horizontalBorder = "+--+";
            Console.Write("Pick a display mode by entering 1 or 2:  ");
            int displayMode = Convert.ToInt32(Console.ReadLine());


            if (displayMode == 1)
            {
                //top border
                for (int i = 0; i < noOfColumns; i++) // use the column count to print the horizontalBorder
                {
                    Console.Write(horizontalBorder, Color.Orange);

                }
                Console.WriteLine("");
                for (int rows = 0; rows < numberOfRows; rows++) // iterate through rows & columns to assign & print random symbolsS 
                {


                    for (int cols = 0; cols < noOfColumns; cols++)
                    {
                        Console.Write("|", Color.Red); // left border
                        playGround[rows, cols] = randomSymbols[random.Next(randomSymbols.Length)];
                        //Console.Write(" 0 ", Color.Pink);
                        Console.Write(" " + playGround[(rows), (cols)] + " ", Color.Bisque);
                        //Console.Write($"Index [{i}*{j}]= {playGround[i , j]}      ");

                    }
                    Console.WriteLine("|", Color.Red); // right border
                    //Bottom border
                    for (int i = 0; i < noOfColumns; i++)
                    {
                        Console.Write(horizontalBorder, Color.Orange);

                    }
                    Console.WriteLine("");
                }

            }

            else if (displayMode == 2) // 2nd display mode for the array
            {
                for (int rows = 0; rows < numberOfRows; rows++) // iterate through rows & columns to assign & print random symbolsS 
                {


                    for (int cols = 0; cols < noOfColumns; cols++)
                    {
                        playGround[rows, cols] = randomSymbols[random.Next(randomSymbols.Length)];
                        Console.Write(playGround[(rows), (cols)]);

                    }
                    Console.WriteLine("");
                }
            }

        }
    }
}
