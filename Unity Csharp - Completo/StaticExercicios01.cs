using System;
using System.Globalization;

namespace Unity_Csharp___Completo
{
    public static class StaticExercicios01
    {
        public static void Exercicios01()
        {
            Console.Write("Qual é a cotação do dólar? ");
            ConversorDeMoeda.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar?: ");
            ConversorDeMoeda.Reais = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = "+ ConversorDeMoeda.Conversao().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
