using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Unity_Csharp___Completo
{
    class Exercicios4
    {
        public void Exercicios01()
        {
            Console.WriteLine("Insira um valor: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                if (i % 2 != 0) Console.WriteLine(i);
            }

        }
        public void Exercicios02()
        {
            int numout = 0;
            int numin = 0;

            Console.WriteLine("Insira a quantidade de valores que vão ser inseridos:");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                Console.WriteLine("Insira um valor: ");
                int num = int.Parse(Console.ReadLine());

                if (num > 9 && num < 21) numin++;
                else numout++;
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine(numin + " in");
            Console.WriteLine(numout + " out");
        }
        public void Exercicios03()
        {
            Console.WriteLine("Insira a quantidade de valores que vão ser inseridos:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }

        public void Exercicios04()
        {
            Console.WriteLine("Insira a quantidade de valores que vão ser inseridos:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite dois numeros: ");
                string[] v = Console.ReadLine().Split(' ');

                double n1 = double.Parse(v[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(v[1], CultureInfo.InvariantCulture);

                double resultado = n1 / n2;

                if (n2 == 0) Console.WriteLine("Divisão Impossivel");
                else Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
            }
        }

        public void Exercicios05()
        {
            Console.WriteLine("Insira um valor: ");
            int valor = int.Parse(Console.ReadLine());
            int resultado = 1;
            

            for (int i = 0; i < valor-1; i++)
            {
                if (valor > 1) resultado *= (valor - i);
            }

            Console.WriteLine(resultado);
        }

        public void Exercicios06()
        {
            Console.WriteLine("Insira um valor: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                if (valor % i == 0) Console.WriteLine(i);
            }
        }

        public void Exercicios07()
        {
            Console.WriteLine("Insira a quantidade de linhas: ");
            int valor = int.Parse(Console.ReadLine());

            for (double i = 1.0; i <= valor ; i++)
                Console.WriteLine((int)i+" "+Math.Pow(i,2.0)+" "+Math.Pow(i,3.0));                
        }
    }
}
