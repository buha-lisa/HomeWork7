namespace hw7.Task2
{
    internal class DeviceBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public DeviceBase() { }
        public virtual void Sound()
        {
            Console.WriteLine($"Sound");
        }
        public virtual void Show()
        {
            Console.WriteLine($"\n{Name}");
        }
        public virtual void Desc()
        {
            Console.WriteLine($"Description\n{Description}\nSize {Size}");
        }
    }
}
