using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Unity_Csharp___Completo
{
    static class Construtores_Exercicio
    {
        public static void Exercicio01()
        {
            Banco conta = new Banco();

            Console.Write("Entre o número da conta: ");
            conta.Conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            conta.Nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");

            if (char.Parse(Console.ReadLine()) == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                conta.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:\n"+conta+"\n");

            Console.Write("Entre um valor para depósito: ");
            conta.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizado:\n"+ conta + "\n");

            Console.Write("Entre um valor para saque: ");
            conta.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizado:\n" + conta + "\n");

        }          
       
    }
}
