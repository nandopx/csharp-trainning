using System;
using demo_abstractMethods.Entities.Enums;

namespace demo_abstractMethods.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle ( double radius, Color color ) : base(color)
        {
            Radius = radius;
        }

        public override double Area ()
        {
            return Math.PI * Math.Pow( Radius, Radius );
        }
    }
}
