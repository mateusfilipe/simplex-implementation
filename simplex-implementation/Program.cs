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

            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }

            float[,] aa = new float[b.Length+1,c.Length];
            for (int i = 0; i < b.Length+1; i++)
            {
                for (int j = 0; j < c.Length; j++)
                {
                    Console.WriteLine(i+" "+j+" "+aa.Length);
                    aa[i, j] = 0;
                }
            }

            for (int i = 0; i < b.Length+1; i++)
            {
                for (int j = 0; j < c.Length; j++)
                {
                    Console.Write(aa[i, j] + " ");
                }
                Console.WriteLine();
            }

            /*
            C_funcaoobjetiva.AddRange(c);
            C_funcaoobjetiva.Add(0);

            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < c.Length; j++)
                {
                    A_restricoesFull.Add(a[i, j]);
                }
                A_restricoesFull.Add(b[i]);
            }


            
            foreach (float dadoAfull in A_restricoesFull)
            {
                  Console.Write(dadoAfull);  
            }
            
            */
        }
    }
}
