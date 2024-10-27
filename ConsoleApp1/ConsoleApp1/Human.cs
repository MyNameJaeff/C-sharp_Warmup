namespace ConsoleApp1
{
    internal class Human : Mammal
    {
        public Human(string name = "Unknown Human", int age = 30, double weight = 70.0, bool isWild = false)
            : base(name, age, weight, isWild)
        {
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} says: Hello!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Hi there!");
        }
    }
}
