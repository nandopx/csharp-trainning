using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace challenge_inheritance_polymorphism.Entities
{
    sealed class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct ()
        {
        }

        public ImportedProduct ( string name, double price, double customsFee ) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag ()
        {
            return base.PriceTag() + CustomsFee + " (Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
