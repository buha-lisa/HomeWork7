namespace hw7.Task2
{
    internal class Car : DeviceBase
    {
        public Car() : base() { }
        public override void Sound()
        {
            Console.WriteLine($"Bib");
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
