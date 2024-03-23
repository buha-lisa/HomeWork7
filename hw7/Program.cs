using One = hw7.Task1;
using Two = hw7.Task2;
using Three = hw7.Task3;
using Four = hw7.Task4;
namespace hw7
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-4): ");
                int.TryParse(Console.ReadLine(), out int task);
                switch (task)
                {
                    case 1:
                        One.MoneyBase money = new One.MoneyBase()
                        {
                            Cash = 13,
                            Penny = 0.23
                        };
                        money.DisplayMoney();
                        One.Product product = new One.Product()
                        {
                            Price = 12
                        };
                        product.DisplayMoney();
                        double rest = product - money;
                        Console.WriteLine($"{rest:F2}");

                        break;
                    case 2:
                        Two.Kettle kettle = new Two.Kettle()
                        {
                            Name = "Kettle",
                            Description = "Elekric",
                            Size = "Small"
                        };
                        kettle.Show();
                        kettle.Sound();
                        kettle.Desc();
                        Two.Microwave microwave = new Two.Microwave()
                        {
                            Name = "Microwave",
                            Description = "Elekric",
                            Size = "Averange"
                        };
                        microwave.Show();
                        microwave.Sound();
                        microwave.Desc();
                        Two.Car car = new Two.Car()
                        {
                            Name = "Car",
                            Description = "Chevrolet",
                            Size = "Big"
                        };
                        car.Show();
                        car.Sound();
                        car.Desc();
                        Two.Steamer steamer = new Two.Steamer()
                        {
                            Name = "Steamer",
                            Description = "Сargo",
                            Size = "Very bid"
                        };
                        steamer.Show();
                        steamer.Sound();
                        steamer.Desc();
                        break;
                    case 3:
                        Three.Violin violin = new Three.Violin()
                        { 
                            Name = "Violin",
                            Description = "String instrument",
                            History = "The violin has a long history, originating in the early 16th century." 
                        };
                        violin.Show();
                        violin.Sound();
                        violin.Desc();
                        violin.HistoryInfo();

                        Three.Trombone trombone = new Three.Trombone()
                        {
                            Name = "Trombone",
                            Description = "Brass instrument",
                            History = "The trombone has a history dating back to the 15th century."
                        };
                        trombone.Show();
                        trombone.Sound();
                        trombone.Desc();
                        trombone.HistoryInfo();

                        Three.Ukulele ukulele = new Three.Ukulele()
                        {
                            Name = "Ukulele",
                            Description = "String instrument",
                            History = "The ukulele originated in the 19th century in Hawaii."
                        };
                        ukulele.Show();
                        ukulele.Sound();
                        ukulele.Desc();
                        ukulele.HistoryInfo();

                        Three.Cello cello = new Three.Cello()
                        {
                            Name = "Cello",
                            Description = "String instrument",
                            History = "The cello has roots dating back to the 16th century."
                        };
                        cello.Show();
                        cello.Sound();
                        cello.Desc();
                        cello.HistoryInfo();
                        break;
                    case 4:
                        Four.President president = new Four.President();
                        president.Print();

                        Four.Security security = new Four.Security();
                        security.Print();

                        Four.Manager manager = new Four.Manager();
                        manager.Print();

                        Four.Engineer engineer = new Four.Engineer();
                        engineer.Print();
                        break;
                }
                if (task == 0) break;
            }
        }        
    }
}
