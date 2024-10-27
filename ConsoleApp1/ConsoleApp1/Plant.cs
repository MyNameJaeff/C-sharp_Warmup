namespace ConsoleApp1
{
    internal abstract class Plant
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }

        public Plant(string name, int age, double height)
        {
            Name = name;
            Age = age;
            Height = height;
        }

        public void Grow()
        {
            Height += 0.2;
            Console.WriteLine($"{Name} has grown to {Height} meters.");
        }
    }
}
