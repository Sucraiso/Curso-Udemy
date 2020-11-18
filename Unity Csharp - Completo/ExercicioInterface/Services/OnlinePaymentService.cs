
namespace Unity_Csharp___Completo.ExercicioInterface.Services
{
    interface OnlinePaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int mounths);
    }
}
