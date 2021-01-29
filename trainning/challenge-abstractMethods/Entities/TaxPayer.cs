
namespace challenge_abstractMethods.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double Anualincome { get; set; }

        protected TaxPayer ( string name, double anualincome )
        {
            Name = name;
            Anualincome = anualincome;
        }

        public abstract double Tax ();
    }
}
