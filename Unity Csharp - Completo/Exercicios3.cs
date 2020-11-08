using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Unity_Csharp___Completo
{
    class Exercicios3
    {
        public void Exercicios01()
        {
            Console.WriteLine("Digite a senha:");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha inválida");
                Console.WriteLine("Digite a senha:");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }

        public void Exercicios02()
        {
            Console.WriteLine("Digite as coordenadas:");
            string[] v = Console.ReadLine().Split(' ');
            int x = int.Parse(v[0]);
            int y = int.Parse(v[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0) Console.WriteLine("Primeiro");

                else if (x < 0 && y > 0) Console.WriteLine("Segundo");

                else if (x < 0 && y < 0) Console.WriteLine("Terceiro");

                else if (x > 0 && y < 0) Console.WriteLine("Quarto");

                Console.WriteLine("Digite as coordenadas:");
                v = Console.ReadLine().Split(' ');
                x = int.Parse(v[0]);
                y = int.Parse(v[1]);
            }
        }

        public void Exercicios03()
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Insira o código: ");
            int codigo = int.Parse(Console.ReadLine());

            while (codigo != 4)
            {
                if (codigo > 0 && codigo < 4)
                {
                    if (codigo == 1) alcool++;
                    else if (codigo == 2) gasolina++;
                    else if (codigo == 3) diesel++;
                }

                if (codigo > 4 || codigo < 1) Console.WriteLine("(Código incorreto) Insira o código:");
                else Console.WriteLine("Insira o código: ");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
