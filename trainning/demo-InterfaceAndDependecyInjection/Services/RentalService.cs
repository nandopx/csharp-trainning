using demo_InterfaceAndDependecyInjection.Entities;
using System;

namespace demo_InterfaceAndDependecyInjection.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _TaxService;

        public RentalService ( double pricePerHour, double pricePerDay, ITaxService taxService )
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _TaxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental )
        {
            var duration = carRental.Finish.Subtract( carRental.Start );
            var basicPayment = 0.0;

            if (duration.TotalHours <= 12.0)
                basicPayment = PricePerHour * Math.Ceiling( duration.TotalHours );
            else
                basicPayment = PricePerDay * Math.Ceiling( duration.TotalHours );

            var tax = _TaxService.Tax( basicPayment );
            carRental.Invoice = new Invoice( basicPayment, tax ); 
        }
    }
}
