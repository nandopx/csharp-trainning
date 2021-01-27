using demo_abstractMethods.Entities;
using demo_abstractMethods.Entities.Enums;
using System.Collections.Generic;
using System;
using System.Globalization;

namespace demo_abstractMethods
{
    class Program
    {
        static void Main ( string[] args )
        {
            Console.Write("Enter the number of shapes: ");
            var numberOfShapes = int.Parse( Console.ReadLine() );

            List<Shape> shape = new List<Shape>();

            for (int i = 0; i < numberOfShapes; i++)
            {
                Console.WriteLine($"Shape #{i + 1} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                var typeOfShape = char.Parse( Console.ReadLine().ToLower() );
                Console.Write("Color (Black/Blue/Red): ");
                var color = Enum.Parse<Color>( Console.ReadLine() );
                

                if (typeOfShape == 'r')
                {
                    Console.Write( "Width: " );
                    var width = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
                    Console.Write( "Height: " );
                    var height = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
                    shape.Add(new Rectangle( width, height, color ));
                }
                else
                {
                    var radius = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
                    shape.Add(new Circle( radius, color ));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (var item in shape)
            {
                Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
