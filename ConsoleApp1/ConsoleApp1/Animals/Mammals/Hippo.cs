namespace ConsoleApp1.Animals.Mammals
{
    internal class Hippo : Mammal
    {
        public int JawStrength { get; set; }

        public Hippo(string name = "Harry", int age = 10, double weight = 1500.0, int jawStrength = 8130, bool isWild = true)
            : base(name, age, weight, isWild)
        {
            JawStrength = jawStrength;
        }

        public void BiteDown()
        {
            Console.WriteLine($"{Name} bites down hard, with the jaw power of {JawStrength}.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} grunts: Hoo Hoo!");
        }
    }
}
