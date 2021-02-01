using challenge_exceptions.Entities;
using System;
using System.Globalization;

namespace challenge_exceptions
{
    class Program
    {
        static void Main ( string[] args )
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            var number = int.Parse( Console.ReadLine() );
            Console.Write("Holder: ");
            var holder = Console.ReadLine();
            Console.Write("initial balance: ");
            var initial = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
            Console.Write("Withdraw limit: ");
            var limit = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );

            var account = new Account( number, holder, initial, limit );

            Console.WriteLine();
            Console.Write("Enter the amount for withdraw: ");
            var withDraw = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
            account.WithDraw( withDraw );
            Console.Write("New balance: $ " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}
