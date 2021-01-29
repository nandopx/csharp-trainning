using challenge_abstractMethods.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace challenge_abstractMethods
{
    class Program
    {
        static void Main ( string[] args )
        {
            List<TaxPayer> taxPayer = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            var numberOfPayers = int.Parse( Console.ReadLine() );

            for (int i = 0; i < numberOfPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write("Indivudual or company (i/c)? ");
                var typeOfPayer = char.Parse( Console.ReadLine().ToLower() );

                // protection to user does not enter a invalid data
                while (typeOfPayer != 'i' && typeOfPayer != 'c')
                {
                    Console.Clear();
                    Console.Write("Wrong input! enter 'c' or 'i': ");
                    typeOfPayer = char.Parse( Console.ReadLine().ToLower() );
                }

                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Anual income: ");
                var anualIncome = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );

                if (typeOfPayer == 'i')
                {
                    Console.Write("Health expenditures: ");
                    var helthExpenditures = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
                    taxPayer.Add( new Individual( name, anualIncome, helthExpenditures ) );
                }
                else
                {
                    Console.Write("Number of employees: ");
                    var numberOfEmployees = int.Parse( Console.ReadLine() );
                    taxPayer.Add( new Company( numberOfEmployees, name, anualIncome ) );
                }
            }

            Console.WriteLine("\nTAXES PAID:");

            var totalTaxes = 0.0;
            foreach (var item in taxPayer)
            {
                Console.WriteLine(item.Name + ": $ " + item.Tax().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += item.Tax();
            }

            Console.WriteLine("\nTOTAL TAXES: $ " + totalTaxes.ToString( "F2", CultureInfo.InvariantCulture ) );
        }
    }
}
