using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_Csharp___Completo.ExercicioInterface.Services
{
    class PaypalService : OnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount += amount * 0.02;
        }

        public double Interest(double amount, int mounths)
        {
            return amount += amount * (mounths * 0.01);
        }
    }
}
