﻿using challenge_enum_composition.Entities;
using challenge_enum_composition.Entities.Enum;
using System.Globalization;
using System.Collections.Generic;
using System;

namespace challenge_enum_composition
{
    class Program
    {
        static void Main ( string[] args )
        {
            Console.WriteLine( "Enter client data:" );
            Console.Write( "Name: " );
            var name = Console.ReadLine();
            Console.Write("Email: ");
            var email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse( Console.ReadLine() );

            Client client = new Client( name, email, birthDate );

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");

            OrderStatus orderStatus = Enum.Parse<OrderStatus>( Console.ReadLine() );
            Order order = new Order(DateTime.Now, orderStatus, client);

            Console.Write("Hoa many items to this order? ");
            var items = int.Parse( Console.ReadLine() );

            for (int i = 0; i < items; i++)
            {
                Console.WriteLine($"Enter item data #{i+1}:");
                Console.Write("Product name: ");
                var productName = Console.ReadLine();
                Console.Write("Product price: ");
                var productPrice = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
                Console.Write( "Quantity: " );
                var quantity = int.Parse( Console.ReadLine() );
                var product = new Product(productName, productPrice);
                var orderItem = new OrderItem( quantity, productPrice, product );
                order.AddItem( orderItem );
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
