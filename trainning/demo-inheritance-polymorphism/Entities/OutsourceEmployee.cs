using System;
using System.Collections.Generic;
using System.Text;

namespace demo_inheritance_polymorphism.Entities
{
    class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee ()
        {
        }

        public OutsourceEmployee ( string name, int hours, double valuePerHour, double additionalCharge ) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment ()
        {
            base.Payment();
            AdditionalCharge += 1.1 * AdditionalCharge;
            return AdditionalCharge;
        }
    }
}
