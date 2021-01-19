using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using challenge_enum_composition.Entities.Enum;

namespace challenge_enum_composition.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order () { }

        public Order ( DateTime moment, OrderStatus status, Client client )
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem ( OrderItem item )
        {
            Items.Add( item );
        }

        public void Removeitem ( OrderItem item )
        {
            Items.Remove( item );
        }

        public double Total ()
        {
            var total = 0.0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString ()
        {
            StringBuilder order = new StringBuilder();
            order.Append( "Order moment: " );
            order.AppendLine( Moment.ToString() );
            order.Append( "Order status: " );
            order.AppendLine( Status.ToString() );
            order.Append( "Client: " );
            order.Append( Client );
            order.AppendLine( "Order items:" );

            foreach (OrderItem item in Items)
            {
                order.Append( item.ToString() );
            }

            order.Append( "Total price: $" );
            order.AppendLine( Total().ToString("F2", CultureInfo.InvariantCulture));

            return order.ToString();
        }
    }
}
