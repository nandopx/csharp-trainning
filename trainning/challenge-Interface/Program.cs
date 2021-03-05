using challenge_Interface.Entities;
using challenge_Interface.Services;
using System;
using System.Globalization;

namespace challenge_Interface
{
    class Program
    {
        static void Main ( string[] args )
        {
            Console.WriteLine( "Enter contract data" );
            Console.Write( "Number: " );
            var number = int.Parse( Console.ReadLine() );
            Console.Write( "Date (dd/MM/yyyy): " );
            var date = DateTime.ParseExact( Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture );
            Console.Write( "Contract value: " );
            var value = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
            Console.Write( "Enter number of installments: " );
            var months = int.Parse( Console.ReadLine() );

            var contract = new Contract( number, date, value );
            ContractService contractService = new ContractService( new PaypalService() );
            contractService.ProcessContract( contract, months );

            Console.WriteLine( "Installments:" );
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine( installment );
            }
        }
    }
}