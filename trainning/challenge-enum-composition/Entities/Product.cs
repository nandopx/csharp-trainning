using System;
using System.Collections.Generic;
using System.Text;

namespace challenge_enum_composition.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; private set; }

        public Product () { }

        public Product ( string name, double price )
        {
            Name = name;
            Price = price;
        }

        public override string ToString ()
        {
            StringBuilder product = new StringBuilder();
            product.Append( Name );
            product.Append( ", " );
            product.Append( Price );

            return product.ToString();
        }
    }
}
