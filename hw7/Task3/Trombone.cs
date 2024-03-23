namespace hw7.Task3
{
    internal class Trombone : MusicalInstrumentBase
    {
        public Trombone() : base() { }

        public override void Sound()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }

        public override void Show()
        {
            Console.WriteLine($"\nName: {Name}");
        }

        public override void Desc()
        {
            Console.WriteLine($"Description: {Description}");
        }

        public override void HistoryInfo()
        {
            Console.WriteLine($"History: {History}");
        }
    }
}
