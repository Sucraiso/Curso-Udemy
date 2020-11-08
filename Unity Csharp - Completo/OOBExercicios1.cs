using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Unity_Csharp___Completo
{
    class OOBExercicios1
    {
        public void Exercicios01()
        {
            Pessoas P1, P2;
            P1 = new Pessoas();
            P2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            P1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            P1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            P2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            P2.idade = int.Parse(Console.ReadLine());

            if (P1.idade > P2.idade) Console.WriteLine("Pessoa mais velha: "+ P1.nome);
            else Console.WriteLine("Pessoa mais velha: "+ P2.nome);

        }

        public void Exercicios02()
        {
            Pessoas F1, F2;
            F1 = new Pessoas();
            F2 = new Pessoas();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            F1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            F1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            F2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            F2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (F1.salario + F2.salario) / 2.0;

            Console.WriteLine("Salário médio = "+ media.ToString("F2", CultureInfo.InvariantCulture));

        }


    }
}
