using System;
using System.Globalization;
using System.Collections.Generic;
using challenge_inheritance_polymorphism.Entities;

namespace challenge_inheritance_polymorphism
{
    class Program
    {
        static void Main ( string[] args )
        {
            Console.Write("Enter the number of products: ");
            var avgproduct = int.Parse( Console.ReadLine() );

            List<Product> product = new List<Product>();

            for (int i = 0; i < avgproduct; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Commom, used or imported (c/u/i)? ");
                var typeOfProduct = char.Parse( Console.ReadLine().ToLower() );
                
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Price: ");
                var price = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );

                switch (typeOfProduct)
                {
                    case 'c': product.Add( new Product( name, price ) ); break;
                    case 'u':
                        Console.Write("Manufacture date: (DD/MM/YYYY): ");
                        var date = DateTime.Parse( Console.ReadLine() );
                        product.Add( new UsedProduct( name, price, date ) );
                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        var customsFee = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
                        product.Add( new ImportedProduct( name, price, customsFee ) );
                        break;
                    default:
                        Console.WriteLine("Invalid data!");
                        break;
                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (var item in product)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
