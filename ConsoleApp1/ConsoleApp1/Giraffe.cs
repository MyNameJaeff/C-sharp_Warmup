namespace ConsoleApp1
{
    internal class Giraffe : Animal
    {
        public double NeckLength { get; set; }
        public Giraffe(string name = "Geoffrey", int age = 5, double weight = 800.0, double neckLength = 2.0)
            : base(name, age, weight, "Giraffe")
        {
            NeckLength = neckLength;
        }

        public void StretchNeck()
        {
            Console.WriteLine($"{Name} stretches its neck, which is {NeckLength} meters long.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes a soft humming sound.");
        }
    }
}
