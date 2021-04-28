using System;

namespace simplex_implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] c = new int[5] { 3, 5, 0, 0, 0 };
            int[,] a = new int[,] { { 2, 4, 1, 0, 0 }, { 6,1,0,1,0 }, { 1,-1,0,0,1} };
            int[,] b = new int[,] { {10}, { 20 }, { 30} };

            int[,] restricoes = new int[,] { { 2, 4, 1, 0, 0 }, { 6, 1, 0, 1, 0 }, { 1, -1, 0, 0, 1 } };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
