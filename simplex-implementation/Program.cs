using System;
using System.Collections.Generic;

namespace simplex_implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] c = new int[] { 3, 5, 0, 0, 0 };
            int[] b = new int[] {10, 20, 30};
            int[,] a = new int[,] { { 2, 4, 1, 0, 0 }, { 6, 1, 0, 1, 0 }, { 1, -1, 0, 0, 1 } };



            List<float> C_funcaoobjetiva = new List<float>();
            List<float> A_restricoes = new List<float>();
            List<float> B_restricoes = new List<float>();

            for(int i = 0; i < c.Length; i++)
            {
                C_funcaoobjetiva.Add(c[i]);
            }
            C_funcaoobjetiva.Add(0);

            for (int i = 0; i < b.Length; i++)
            {
                float[] aux = new float[] { };
                for (int j = 0; j < c.Length; j++)
                {
                    A_restricoes.Add(a[i, j]);
                }
                
            }

            foreach (float dadoB in B_restricoes)
            {
                Console.WriteLine(dadoB);
            }


        }
    }
}
