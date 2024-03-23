using System.Dynamic;

namespace hw7.Task1
{
    internal class Product : MoneyBase
    {
        public double Price { get; set; }
        public Product() : base() { }

        public static double operator -(Product product, MoneyBase money)
        {
            return (money.Cash + money.Penny) - product.Price;
        }
        public override void DisplayMoney()
        {
            Console.WriteLine($"{Price}");
        }
    }
}
