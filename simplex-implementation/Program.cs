using System;
using System.Collections.Generic;

namespace simplex_implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] c = new float[] { 3, 5, 0, 0, 0 };
            float[] b = new float[] {10, 20, 30};
            float[,] a = new float[,] {{ 2, 4, 1, 0, 0 }, 
                                       { 6, 1, 0, 1, 0 }, 
                                       { 1, -1, 0, 0, 1 }};
            
            Array.Resize(ref c, c.Length + 1);
            c[c.Length-1] = 0;

            float[,] aa = new float[b.Length+1,c.Length];

            for (int j = 0; j < c.Length; j++)
            {
                aa[0, j] = c[j];
            }

            for (int j = 0; j < b.Length; j++)
            {
                aa[c.Length-1, j] = b[j];
            }

            for (int i = 0; i < b.Length+1; i++)
            {
                for (int j = 0; j < c.Length; j++)
                {
                    Console.Write(aa[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
