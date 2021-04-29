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

            float[,] matrizInicial = new float[b.Length+1,c.Length];

            for (int j = 0; j < c.Length; j++)
            {
                matrizInicial[0, j] = c[j];
            }

            for (int j = 0; j < b.Length; j++)
            {
                matrizInicial[j+1, c.Length - 1] = b[j];
            }

            for (int i = 1 ; i < b.Length + 1; i++)
            {
                for (int j = 0 ; j < c.Length-1; j++)
                {
                    matrizInicial[i, j] = a[i-1,j];
                }
            }

            for (int i = 0; i < b.Length+1; i++)
            {
                for (int j = 0; j < c.Length; j++)
                {
                    Console.Write(matrizInicial[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Agrupamento dos dados concluidos e matriz inicial armazenadas

        }
    }
}
