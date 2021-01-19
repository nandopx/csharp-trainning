using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace challenge_enum_composition.Entities
{
    class OrderItem
    {
        public int Quantity { get; private set; }
        public double Price { get; private set; }
        public Product Product { get; set; }

        public OrderItem () { }

        public OrderItem ( int quantity, Product product )
        {
            Quantity = quantity;
            Price = product.Price;
            Product = product;
        }
         
        public double SubTotal ()
        {
            return Quantity * Price;
        }

        public override string ToString ()
        {
            StringBuilder orderItems = new StringBuilder();
            orderItems.Append( Product );
            orderItems.Append( ", Quantity: " );
            orderItems.Append( Quantity );
            orderItems.Append( ", Subtotal: $" );
            orderItems.AppendLine( SubTotal().ToString("F2", CultureInfo.InvariantCulture) );


            return orderItems.ToString();
        }
    }
}
