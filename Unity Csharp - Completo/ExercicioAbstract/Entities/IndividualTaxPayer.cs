using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_Csharp___Completo.ExercicioAbstract.Entities
{
    class IndividualTaxPayer : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public IndividualTaxPayer(string name, double income, double healthExpenditures)
            : base(name,income)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesToPaid()
        {
            if (Income < 2000.0)
            {
                return Income * 0.15 - (HealthExpenditures * 0.5);
            }
            else
            {
                return Income * 0.25 - (HealthExpenditures * 0.5);
            }
        }
    }
}
