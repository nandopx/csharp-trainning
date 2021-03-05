using demo_InterfaceAndDependecyInjection.Entities;
using demo_InterfaceAndDependecyInjection.Services;
using System;
using System.Globalization;

namespace demo_InterfaceAndDependecyInjection
{
    class Program
    {
        static void Main ( string[] args )
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car Model: ");
            var model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:MM): ");
            var start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write( "Return (dd/MM/yyyy hh:MM): " );
            var finish = DateTime.ParseExact( Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture );

            Console.Write("Enter price per hour: ");
            var hour = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
            Console.Write( "Enter price per day: " );
            var day = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );

            var carRental = new CarRental( start, finish, new Vehicle( model ) );
            var rentalService = new RentalService( hour, day, new BrazilTaxService() );

            rentalService.ProcessInvoice( carRental );

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
