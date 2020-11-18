using System;
using System.Collections.Generic;
using System.Text;
using Unity_Csharp___Completo.ExercicioInterface.Entities;
using Unity_Csharp___Completo.ExercicioInterface.Services;
using System.Globalization;

namespace Unity_Csharp___Completo.ExercicioInterface
{
    class MainExercicioInterface
    {
        public void Exercicio()
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int n = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);
            ContractService contractService = new ContractService();
            contractService.ProcessContract(contract, n, new PaypalService());

            Console.WriteLine();
            Console.WriteLine("Instalments: ");
            foreach (Installment install in contract.InstallmentsList) Console.WriteLine(install);

        }
    }
}
