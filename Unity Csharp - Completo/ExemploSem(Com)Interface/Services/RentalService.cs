using System;
using System.Collections.Generic;
using System.Text;
using Unity_Csharp___Completo.ExemploSemInterface.Entities;

namespace Unity_Csharp___Completo.ExemploSemInterface.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _TaxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _TaxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment;

            if (duration.TotalHours <= 12.0) basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            else basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);

            double tax = _TaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
