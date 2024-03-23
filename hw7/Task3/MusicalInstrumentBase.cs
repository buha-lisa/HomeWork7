namespace hw7.Task3
{
    internal class MusicalInstrumentBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string History { get; set; }

        public MusicalInstrumentBase() {}

        public virtual void Sound()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }

        public virtual void Show()
        {
            Console.WriteLine($"\nName: {Name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"Description: {Description}");
        }

        public virtual void HistoryInfo()
        {
            Console.WriteLine($"History: {History}");
        }
    }
}
