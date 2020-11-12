using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_Csharp___Completo.ExercicioAbstract.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double Income { get; set; }

        protected TaxPayer(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double TaxesToPaid();
    }
}
