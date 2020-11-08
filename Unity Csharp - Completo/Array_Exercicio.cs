using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_Csharp___Completo
{
    static class Array_Exercicio
    {
        public static void Exercicio()
        {
            Estudantes[] vect = new Estudantes[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #"+(i+1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                vect[int.Parse(Console.ReadLine())] = new Estudantes(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados:");

            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null) Console.WriteLine(i + ": " + vect[i].ToString());

            }

        }
    }
}
