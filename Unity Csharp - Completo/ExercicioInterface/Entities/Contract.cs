using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_Csharp___Completo.ExercicioInterface.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> InstallmentsList { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;      
            InstallmentsList = new List<Installment>();
        }
    }
}
