
namespace challenge_abstractMethods.Entities
{
    class Individual : TaxPayer
    {
        public double HelthExpenditures { get; set; }

        public Individual ( string name, double anualIncome, double helthExpenditures ) : base(name, anualIncome)
        {
            HelthExpenditures = helthExpenditures;
        }

        public override double Tax ()
        {
            var tax = 0.0;
            if (Anualincome < 20000.00)
                tax += Anualincome * 0.25;

            if (HelthExpenditures > 0)
                tax -= HelthExpenditures * 0.50;

            return tax;
        }
    }
}
