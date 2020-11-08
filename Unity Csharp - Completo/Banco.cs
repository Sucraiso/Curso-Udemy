using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Unity_Csharp___Completo
{
    class Banco
    {
        private double _saldo = 0.0;
        public int _conta { get; private set; }

        public string Nome { get; set; }

        public int Conta
        {
            get { return _conta; }
            set { _conta = value;}
        }

        public void Deposito(double valor)
        {
            _saldo += valor;            
        }
        public void Saque(double valor)
        {
            _saldo -= (valor+5.0);            
        }

        public override string ToString()
        {
            return "Conta " + _conta + ", Titular: " + Nome + ", Saldo: $ " + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
