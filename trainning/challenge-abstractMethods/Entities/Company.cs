
namespace challenge_abstractMethods.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployeers { get; set; }

        public Company ( int numberOfEmployeers, string name, double anualIncome ) : base(name,anualIncome)
        {
            NumberOfEmployeers = numberOfEmployeers;
        }

        public override double Tax ()
        {
            if (NumberOfEmployeers > 10)
                return Anualincome * 0.14;
            else
                return Anualincome * 0.16;
        }
    }
}
