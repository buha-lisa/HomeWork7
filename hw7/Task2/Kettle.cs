namespace hw7.Task2
{
    internal class Kettle : DeviceBase
    {
        public Kettle() : base() { }
        public override void Sound()
        {
            Console.WriteLine($"Whistle");
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
