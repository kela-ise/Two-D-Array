namespace Two_D_Array_Game
{
   
 
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            char[] randomSymbols = { '%', '*', '+', '@', '&', '#', '$', '!', '?' };// characters that will be randomly placed in the grid/array
            Console.WriteLine("2D Array");
            Console.Write("Enter # of Rows: ");
            int numberOfRows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter # of Cols: ");
            int noOfColumns = Convert.ToInt32(Console.ReadLine());
            char[,] playGround = new char[numberOfRows, noOfColumns];// using char because of randomSymbols
            Console.WriteLine($"Your Array has {numberOfRows} rows & {noOfColumns} cols"); // 2d array

            // iterate through rows & columns to assign & print random symbolsS 
            for (int rows = 0; rows < numberOfRows; rows++)
            {
                for (int cols = 0; cols < noOfColumns; cols++)
                {
                    playGround[rows, cols] = randomSymbols[random.Next(randomSymbols.Length)];
                    Console.Write(playGround[rows, cols]+ "  \t");
                    //Console.Write($"Index [{i}*{j}]= {playGround[i , j]}      ");
                }
                Console.WriteLine();
            }

        }
    }
}
