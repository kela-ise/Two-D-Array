namespace Two_D_Array_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2D Array");
            Console.Write("Enter # of Rows: ");
            int enterRows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter # of Cols: ");
            int enterCol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your Array has {enterRows} rows & {enterCol} cols");
            int[,] playGround = new int[enterRows, enterCol];


        }
    }
}
