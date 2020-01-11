using System.Globalization;

namespace ProductInStock
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double TotalValueInStock()
        {
            return Price * Quantity;
        }

        public void AddProduct(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return Name
                + ", $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantity
                + " Units, Total: $ "
                + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}