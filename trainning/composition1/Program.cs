using composition1.Entities.Enums;
using System.Globalization;
using System;
using composition1.Entities;

namespace composition1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            var deptname = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            var baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptname);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker: ");
            var numberOfContracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfContracts; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter the contract data #{i+1}:");
                Console.Write("Date (DD/MM/YYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: $ ");
                var valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration: (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            var monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": $ " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
