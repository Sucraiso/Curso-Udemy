using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_Csharp___Completo.ExercicioAbstract.Entities
{
    class CompanyTaxPayer : TaxPayer
    {
        public int Employees { get; set; }

        public CompanyTaxPayer(string name, double income, int employees)
            :base (name,income)
        {
            Employees = employees;
        }
        public override double TaxesToPaid()
        {
            if (Employees < 10)
            {
                return Income * 0.16;
            }
            else
            {
                return Income * 0.14;
            }
        }
    }
}
