namespace ConsoleApp1.Animals.Mammals
{
    internal class Giraffe : Mammal
    {
        public double NeckLength { get; set; }

        public Giraffe(string name = "Geoffrey", int age = 5, double weight = 800.0, double neckLength = 2.0, bool isWild = true)
            : base(name, age, weight, isWild)
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
