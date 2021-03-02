
using System.Globalization;

namespace workingWithFiles
{
    class Product
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Quantidade { get; set; }

        public Product ( string title, decimal price, int quantidade )
        {
            Title = title;
            Price = price;
            Quantidade = quantidade;
        }

        public decimal Total ()
        {
            return Price* Quantidade;
        }

        public override string ToString ()
        {
            return Title
                   + ", "
                   + Price.ToString("F2", CultureInfo.InvariantCulture)
                   + ", "
                   + Quantidade;
        }
    }
}
