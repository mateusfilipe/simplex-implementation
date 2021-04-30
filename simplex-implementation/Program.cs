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
            

            /*
            float[] c = new float[] { 4, 7, 0, 0, 0 };
            float[] b = new float[] {6, 8, 10};
            float[,] a = new float[,] {{ 1, 0, 1, 0, 0 }, 
                                       { 0, 1, 0, 1, 0 }, 
                                       { 4, -2, 0, 0, 1 }};
            */
            
            Array.Resize(ref c, c.Length + 1);
            c[c.Length-1] = 0;

            float[,] matrizInicial = new float[b.Length+1,c.Length];

            for (int j = 0; j < c.Length; j++)
            {
                matrizInicial[0, j] = 0 - c[j];
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
            float menor = matrizInicial[0, 0];
            int colunaMenor = 0;
            for (int j = 0; j < c.Length; j++)
            {
                if (matrizInicial[0, j] < menor) {
                    menor = matrizInicial[0, j];
                    colunaMenor = j;
                }
            }

            float elementoPivo = matrizInicial[1, colunaMenor];
            int linhaPivo = 1;
            
            for (int i = 1; i < b.Length + 1; i++)
            {
                float razao = -1;
                if (matrizInicial[i, colunaMenor] != 0)
                {
                    razao = (matrizInicial[i, c.Length - 1] / matrizInicial[i, colunaMenor]);
                }
                Console.WriteLine("razao: "+razao);
                Console.WriteLine("elemento pivo: "+elementoPivo);
                if (razao >=  0 && razao < elementoPivo)
                {
                    Console.WriteLine("entrou aqui");
                    elementoPivo = matrizInicial[i, colunaMenor];
                    linhaPivo = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pivô: "+elementoPivo + " Linha:" + linhaPivo);
            Console.WriteLine();


            //Matriz Inicial Alterada, divisão para encontrar pivô
            float[,] matrizAuxiliar = new float[b.Length + 1, c.Length];

            for (int j = 0; j < c.Length; j++)
            {
                matrizAuxiliar[0, j] = 0 - c[j];
            }

            for (int j = 0; j < c.Length; j++)
            {
                matrizInicial[linhaPivo, j] = matrizInicial[linhaPivo, j] / elementoPivo;
            }

            matrizAuxiliar = (float[,])matrizInicial.Clone();

            Console.WriteLine("Matriz Auxiliar:");
            for (int i = 0; i < b.Length + 1; i++)
            {
                for (int j = 0; j < c.Length; j++)
                {
                    Console.Write(matrizAuxiliar[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < b.Length + 1; i++)
            {
                float multiplicadorColuna = matrizAuxiliar[i, colunaMenor];
                if(i != linhaPivo)
                {
                    for (int j = 0; j < c.Length; j++)
                    {
                        {
                            // Multiplicando o elemento da coluna demarcada, pela linha pivo.
                            matrizAuxiliar[i, j] = multiplicadorColuna  * matrizInicial[linhaPivo, j]; 
                        }
                    }
                }
                
            }

            for (int i = 0; i < b.Length + 1; i++)
            {
                if (i != linhaPivo)
                {
                    for (int j = 0; j < c.Length; j++)
                    {
                        {
                            // Soma da linha da matriz antiga com o resultado obtido anteriormente
                            matrizAuxiliar[i, j] = matrizInicial[i,j] - matrizAuxiliar[i, j];
                        }
                    }
                }

            }

            Console.WriteLine();
            Console.WriteLine("Nova Matriz Auxiliar:");
            for (int i = 0; i < b.Length + 1; i++)
            {
                for (int j = 0; j < c.Length; j++)
                {
                    Console.Write(matrizAuxiliar[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
