using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_Csharp___Completo
{
    static class ConversorDeMoeda
    {
        public static double Cotacao;
        public static double Reais;
        
        public static double Conversao()
        {
            return (Reais * Cotacao) * 1.06;

        }
    }
}
