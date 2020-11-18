using System;
using System.Collections.Generic;
using System.Text;
using Unity_Csharp___Completo.ExercicioInterface.Entities;

namespace Unity_Csharp___Completo.ExercicioInterface.Services
{
    class ContractService
    {       

        public void ProcessContract(Contract contract, int mounths, OnlinePaymentService paymentService)
        {
            for(int i = 1; i <= mounths; i++)
            {
                double totalPay = paymentService.PaymentFee(paymentService.Interest(contract.TotalValue/mounths, i));
                                
                contract.InstallmentsList.Add(new Installment(contract.Date.AddMonths(i), totalPay));
            }
        }
    }
}
