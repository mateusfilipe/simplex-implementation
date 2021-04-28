using System;
using System.Collections.Generic;

namespace simplex_implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] c = new int[5] { 3, 5, 0, 0, 0 };
            int[] b = new int[] {10, 20, 30};
            int[,] a = new int[,] { { 2, 4, 1, 0, 0 }, { 6, 1, 0, 1, 0 }, { 1, -1, 0, 0, 1 } };

            List<float> C_funcaoobjetiva = new List<float>();
            List<float> A_restricoes = new List<float>();
            List<float> B_igualdades = new List<float>();

            for(int i = 0; i < c.Length; i++)
            {
                C_funcaoobjetiva.Add(c[i]);
            }
            for (int i = 0; i < b.Length; i++)
            {
                B_igualdades.Add(b[i]);
            }

            foreach (float dadoB in B_igualdades)
            {
                Console.WriteLine(dadoB);
            }

        }
    }
}
