using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Unity_Csharp___Completo
{
    class Exercicios1
    {
        public void Exercicios01()
        {
            Console.WriteLine("Escreva o primeiro valor: ");
            int ex1n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo valor: ");
            int ex1n2 = int.Parse(Console.ReadLine());

            int soma = ex1n1 + ex1n2;
            Console.WriteLine("SOMA = "+ soma);
        }

        public void Exercicios02()
        {
            double pi = 3.14159;

            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * (Math.Pow(raio , 2.0));

            Console.WriteLine("A = "+ area.ToString("F4", CultureInfo.InvariantCulture));
                        
        }

        public void Exercicios03()
        {
            Console.WriteLine("Insira o valor A: ");
            int nA = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor B: ");
            int nB = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor C: ");
            int nC = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor D: ");
            int nD = int.Parse(Console.ReadLine());

            int diferenca = (nA * nB) - (nC * nD);

            Console.WriteLine("DIFERENCA = "+ diferenca);
        }

        public void Exercicios04()
        {
            Console.WriteLine("Insira seu número: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira suas horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira seu salário: ");
            float salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float resultado = horas * salario;
            Console.WriteLine($"NUMBER = {number}\nSALARY = U$ {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public void Exercicios05()
        {
            Console.WriteLine("(01)Insira o código, a quantidade e depois o seu valor: ");
            string[] vetor1 = Console.ReadLine().Split(' ');

            int codigo1 = int.Parse(vetor1[0]);
            int quant1 = int.Parse(vetor1[1]);
            float valor1 = float.Parse(vetor1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("(02)Insira o código, a quantidade e depois o seu valor: ");
            string[] vetor2 = Console.ReadLine().Split(' ');

            int codigo2 = int.Parse(vetor2[0]);
            int quant2 = int.Parse(vetor2[1]);
            float valor2 = float.Parse(vetor2[2], CultureInfo.InvariantCulture);

            float valorTotal = (quant1 * valor1) + (quant2 * valor2);

            Console.WriteLine($"VALOR A PAGAR: R${valorTotal.ToString("F2", CultureInfo.InvariantCulture)}"); 
        }

        public void Exercicios06()
        {
            Console.WriteLine("Insira os três valores:");
            string[] v = Console.ReadLine().Split(' ');

            double nA = double.Parse(v[0], CultureInfo.InvariantCulture);
            double nB = double.Parse(v[1], CultureInfo.InvariantCulture);
            double nC = double.Parse(v[2], CultureInfo.InvariantCulture);

            double areaTriRetangulo = (nA * nC) / 2.0;
            double areaCirculo = 3.14159 * (Math.Pow(nC, 2.0));
            double areaTrapezio = ((nA + nB) * nC) / 2.0;
            double areaQuadrado = Math.Pow(nB, 2.0);
            double areaRetangulo = nA * nB;

            Console.WriteLine("TRIANGULO: "+ areaTriRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: "+ areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: "+ areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: "+ areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: "+ areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
