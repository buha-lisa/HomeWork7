namespace hw7.Task2
{
    internal class Microwave : DeviceBase
    {
        public Microwave() : base() { }
        public override void Sound()
        {
            Console.WriteLine($"Dzin");
        }
        public override void Show()
        {
            Console.WriteLine($"\n{Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Description\n{Description}\nSize {Size}");
        }
    }
}
