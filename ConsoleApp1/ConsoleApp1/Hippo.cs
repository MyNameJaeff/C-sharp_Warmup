namespace ConsoleApp1
{
    internal class Hippo : Animal
    {
        public int JawStrength { get; set; }
        // Konstruktor med defaultvärden
        public Hippo(string name = "Harry", int age = 10, double weight = 1500.0, int jawStrength = 8130)
            : base(name, age, weight, "Hippo")
        {
            JawStrength = jawStrength;
        }

        public void BiteDown()
        {
            Console.WriteLine($"{Name} bites down hard, with the jaw power of {JawStrength}!.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} grunts: Hoo Hoo!");
        }
    }
}
