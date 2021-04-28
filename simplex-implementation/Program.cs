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
            float[,] a = new float[,] { { 2, 4, 1, 0, 0 }, { 6, 1, 0, 1, 0 }, { 1, -1, 0, 0, 1 } };



            List<float> C_funcaoobjetiva = new List<float>();
            List<float> A_restricoes = new List<float>();
            List<float> B_restricoes = new List<float>();

            List<float> A_restricoesFull = new List<float>();



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
            

        }
    }
}
