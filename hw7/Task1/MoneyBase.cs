namespace hw7.Task1
{
    internal class MoneyBase
    {
        public int Cash { get; set; }
        public double Penny { get; set; }

        public void SetCash(int cash)
        {
            Cash = cash;
        }
        public void SetPenny(double penny)
        {
            Penny = penny;
        }

        public MoneyBase() { }

        public virtual void DisplayMoney()
        {
            Console.WriteLine($"{Cash+Penny}");
        }
    }
}
