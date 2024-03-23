namespace hw7.Task2
{
    internal class Steamer : DeviceBase
    {
        public Steamer() : base() { }
        public override void Sound()
        {
            Console.WriteLine($"Weem");
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
