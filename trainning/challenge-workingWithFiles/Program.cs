using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace workingWithFiles
{
    class Program
    {
        static void Main ( string[] args )
        {
            var sourcepath = @"c:\temp\products.csv";
            var targetPath = @"c:\temp\summary.csv";
            var products = new List<Product>();

            try
            {
                //Opening source file
                using (StreamReader imput = File.OpenText( sourcepath ))
                {
                    while (!imput.EndOfStream)
                    {
                        string[] lineFile = imput.ReadLine().Split( ',' );
                        var title = lineFile[0];
                        var price = decimal.Parse( lineFile[1], CultureInfo.InvariantCulture );
                        var qtd = int.Parse( lineFile[2] );
                        products.Add( new Product( title, price, qtd ) ); // creating a object and adding to list
                    }
                }

                // writing to target file
                using (StreamWriter output = File.AppendText( targetPath ))
                {
                    foreach (Product product in products)
                    {
                        output.WriteLine( product.Title + "," + product.Total().ToString() );
                    }
                }

                //Opening source file
                Console.WriteLine( "Source file(" + new DirectoryInfo( sourcepath ) + "):\n" );
                using (StreamReader file = File.OpenText( sourcepath ))
                {
                    string input = file.ReadToEnd();
                    Console.WriteLine( input );
                }

                //Opening target file
                Console.WriteLine( "\nOutput file (" + new DirectoryInfo(targetPath) + "):\n");
                using (StreamReader file = File.OpenText( targetPath ))
                {
                    string output = file.ReadToEnd();
                    Console.WriteLine( output );
                }
            }
            catch (AppException e)
            {

                throw new AppException( "An error ocurred: " + e.Message );
            }
            catch (IOException e)
            {
                Console.WriteLine( "An error ucurred: " + e.Message );
            }
        }
    }
}
