using demo_inheritance_polymorphism.Entities;
using System.Collections.Generic;
using System.Globalization;
using System;

namespace demo_inheritance_polymorphism
{
    class Program
    {
        static void Main ( string[] args )
        {
            Console.Write("Enter the number of employees: ");
            var numberOfEmployees = int.Parse( Console.ReadLine() );

            List<Employee> employee = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine($"Employee #{i+1} data:");
                Console.Write("Outsourced (y/n)? ");
                var typeOfEmployee = char.Parse( Console.ReadLine().ToLower() );
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Hours: ");
                var hours = int.Parse( Console.ReadLine() );
                Console.Write("Value per hour: ");
                var valuePerHour = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );

                if (typeOfEmployee == 'y')
                {
                    Console.Write("Additional charge: ");
                    var additionalCharge = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
                    employee.Add( new OutsourceEmployee(name, hours, valuePerHour, additionalCharge) );
                }
                else
                {
                    employee.Add( new Employee( name, hours, valuePerHour ) );
                }
            }
            Console.WriteLine();
            Console.WriteLine( "PAYMENTS:" );
            foreach (var item in employee)
            {
                Console.WriteLine( item.Name + " - " + "$ " + item.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
