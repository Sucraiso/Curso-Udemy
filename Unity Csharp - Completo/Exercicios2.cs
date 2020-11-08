using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Unity_Csharp___Completo
{
    class Exercicios2
    {
        public void Exercicios01()
        {
            Console.WriteLine("Insira um numero inteiro:");
            int number = int.Parse(Console.ReadLine());

            if (number < 0) Console.WriteLine("NEGATIVO");
            else Console.WriteLine("NÃO NEGATIVO");
        }

        public void Exercicios02()
        {
            Console.WriteLine("Insira um numero inteiro:");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) Console.WriteLine("PAR");
            else Console.WriteLine("IMPAR");
        }

        public void Exercicios03()
        {
            Console.WriteLine("Digite o primeiro numero inteiro:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero inteiro:");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 % number2 == 0 || number2 % number1 == 0) Console.WriteLine("SAO MULTIPLOS");
            else Console.WriteLine("NAO SAO MULTIPLOS");
        }

        public void Exercicios04()
        {
            int horasJogadas;

            Console.WriteLine("Digite a hora que começou:");
            int horas1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a hora que terminou:");
            int horas2 = int.Parse(Console.ReadLine());

            if (horas1 < horas2)
            {
                horasJogadas = horas2 - horas1;
            }
            else
            {
                horasJogadas = 24 - horas1 + horas2;
            }

            Console.WriteLine("O JOGO DUROU " + horasJogadas + " HORA(S).");
        }

        public void Exercicios05()
        {
            Console.WriteLine("Insira o código do item e a quantidade:");
            String[] v = Console.ReadLine().Split(' ');
            int codigo = int.Parse(v[0]);
            int quant = int.Parse(v[1]);

            float total = 0;

            if (codigo == 1) total = 4.0f * quant;

            else if (codigo == 2) total = 4.5f * quant;

            else if (codigo == 3) total = 5.0f * quant;

            else if (codigo == 4) total = 2.0f * quant;

            else if (codigo == 5) total = 1.5f * quant;

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }

        public void Exercicios06()
        {
            Console.WriteLine("Insira um numero:");
            float num = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num >= 0.0f && num <= 25.0f) Console.WriteLine("Intervalo [0,25]");

            else if (num > 25.0f && num <= 50.0f) Console.WriteLine("Intervalo [25,50]");

            else if (num > 50.0f && num <= 75.0f) Console.WriteLine("Intervalo [50,75]");

            else if (num > 75.0f && num <= 100.0f) Console.WriteLine("Intervalo [75,100]");

            else Console.WriteLine("Fora de intervalo");
        }

        public void Exercicios07()
        {
            Console.WriteLine("Insira as coordenadas:");
            string[] v = Console.ReadLine().Split(' ');
            float x = float.Parse(v[0], CultureInfo.InvariantCulture);
            float y = float.Parse(v[1], CultureInfo.InvariantCulture);

            if (x > 0 && y > 0) Console.WriteLine("Q1");

            else if (x < 0 && y > 0) Console.WriteLine("Q2");

            else if (x < 0 && y < 0) Console.WriteLine("Q3");

            else if (x > 0 && y < 0) Console.WriteLine("Q4");

            else if (x == 0 && y > 0) Console.WriteLine("Origem entre Q1 e Q2");

            else if (x == 0 && y < 0) Console.WriteLine("Origem entre Q3 e Q4");

            else if (x > 0 && y == 0) Console.WriteLine("Origem entre Q1 e Q4");

            else if (x < 0 && y == 0) Console.WriteLine("Origem entre Q2 e Q3");

            else Console.WriteLine("Origem Central");

        }

        public void Exercicios08()
        {
            Console.WriteLine("Insira o salario:");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0) imposto = 0.0;

            else if (salario <= 3000.0) imposto = (salario - 2000.0) * 0.08;

            else if (salario <= 4500.0) imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;

            else imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;

            if (imposto == 0.0) Console.WriteLine("Isento");

            else Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
