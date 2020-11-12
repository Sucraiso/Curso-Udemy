using System;
using System.Collections.Generic;
using System.Text;
using Unity_Csharp___Completo.ExercicioAbstract.Entities;
using System.Globalization;

namespace Unity_Csharp___Completo.ExercicioAbstract
{
    public class MainExercicioAbstract
    {
        public void Exercicio()
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new IndividualTaxPayer(name, income, health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new CompanyTaxPayer(name, income, employees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0;

            foreach (TaxPayer tax in list)
            {
                Console.WriteLine(tax.Name+": $ "+tax.TaxesToPaid().ToString("F2", CultureInfo.InvariantCulture));
                sum += tax.TaxesToPaid();
            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: $ "+sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
