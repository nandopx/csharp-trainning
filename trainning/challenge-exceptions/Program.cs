using challenge_exceptions.Entities;
using System;
using System.Globalization;
using challenge_exceptions.Entities.Exceptions;

namespace challenge_exceptions
{
    class Program
    {
        static void Main ( string[] args )
        {
            try
            {
                Console.WriteLine( "Enter account data" );
                Console.Write( "Number: " );
                var number = int.Parse( Console.ReadLine() );
                Console.Write( "Holder: " );
                var holder = Console.ReadLine();
                Console.Write( "initial balance: " );
                var initial = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
                Console.Write( "Withdraw limit: " );
                var limit = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );

                var account = new Account( number, holder, initial, limit );

                Console.WriteLine();
                Console.Write( "Enter the amount for withdraw: " );
                var withDraw = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );


                account.WithDraw( withDraw );
                Console.Write( "New balance: $ " + account.Balance.ToString( "F2", CultureInfo.InvariantCulture ) );
                Console.WriteLine();
            }
            catch (DomainException e)
            {
                Console.WriteLine( "Withdraw error: " + e.Message );
            }
            catch (FormatException e)
            {
                Console.WriteLine( "Format error: " + e.Message );
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
