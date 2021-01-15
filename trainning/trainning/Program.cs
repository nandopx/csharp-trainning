using System;
using trainning.Entities;
using trainning.Entities.Enums;

namespace trainning
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            // show a order
            Console.WriteLine(order);

            // converting Enum to string
            string txt = OrderStatus.PendingPayment.ToString();

            // convert string to Enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
