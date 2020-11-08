using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Unity_Csharp___Completo
{
    class Aluno
    {
        public string Nome;
        public double NotaFinal;

        public void NotaFinalMedia(double n1, double n2, double n3)
        {
            NotaFinal = n1 + n2 + n3;
        }

        public override string ToString()
        {
            if (NotaFinal >= 60.0) return "NOTA FINAL = " + NotaFinal.ToString("F2", CultureInfo.InvariantCulture)+ "\nAPROVADO";

            else return "NOTA FINAL = " + NotaFinal.ToString("F2", CultureInfo.InvariantCulture)+"\n"+
                "REPROVADO \n" +
                "FALTARAM "+ (60.0 - NotaFinal).ToString("F2",CultureInfo.InvariantCulture)+" PONTOS";
        }
    }
}
