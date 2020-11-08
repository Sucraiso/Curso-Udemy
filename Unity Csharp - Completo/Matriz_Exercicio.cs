using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_Csharp___Completo
{
    static class Matriz_Exercicio
    {
        public static void Exercicio()
        {
            Console.WriteLine("Insira o numero de linhas e colunas: ");
            string[] matInput = Console.ReadLine().Split(' ');

            int[,] mat = new int[int.Parse(matInput[0]), int.Parse(matInput[1])];

            Console.WriteLine("Insira os dados, linha por linha");

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                matInput = Console.ReadLine().Split(' ');

                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = int.Parse(matInput[j]);
                }
            }
            
            Console.WriteLine();
            Console.Write("Insira um valor para rastrear-lo: ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine();

            
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i,j] == target)
                    {
                        Console.WriteLine("Position "+i+", "+j+":");
                        if (i - 1 >= 0) Console.WriteLine("Up: "+ mat[i-1,j]);
                        if (j - 1 >= 0) Console.WriteLine("Left: "+ mat[i,j-1]);
                        if (j + 1 < mat.GetLength(1)) Console.WriteLine("Right: "+ mat[i, j+1]);
                        if (i + 1 < mat.GetLength(0)) Console.WriteLine("Down: "+ mat[i+1, j]);
                        Console.WriteLine();
                    }
                    
                }
            }      
                        
        }
    }
}
