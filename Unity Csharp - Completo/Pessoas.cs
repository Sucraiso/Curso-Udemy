using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Unity_Csharp___Completo
{
    class Pessoas
    {
        public string nome;
        public int idade;

        public double salario;
        public double imposto;

        public double SalarioLiquido()
        {
            return salario - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            salario += salario * (porcentagem/100.0);
        }

        public override string ToString()
        {
            return nome+ ", $ "+ SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
