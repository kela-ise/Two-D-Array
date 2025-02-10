namespace Two_D_Array_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int PLAYGROUND_INDEX = 0;
            Random random = new Random();
            char[] randomSymbols = { '%', '*', '+', '@', '&', '#', '$', '!', '?' };// characters that will be randomly placed in the grid/array
            Console.WriteLine("2D Array");
            Console.Write("Enter # of Rows: ");
            int enterRows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter # of Cols: ");
            int enterCol = Convert.ToInt32(Console.ReadLine());// using char because of randomSymbols
            char[,] playGround = new char[enterRows, enterCol];
            Console.WriteLine($"Your Array has {enterRows} rows & {enterCol} cols"); // 2d array

            // iterate through i & j to assign & print random symbolsS 
            for (int i = PLAYGROUND_INDEX; i < enterRows; i++)
            {
                for (int j = PLAYGROUND_INDEX; j < enterCol; j++)
                {
                    playGround[i, j] = randomSymbols[random.Next(randomSymbols.Length)];

                    Console.WriteLine(playGround[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
