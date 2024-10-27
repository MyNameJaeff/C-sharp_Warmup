namespace ConsoleApp1
{
    internal class Lion : Mammal
    {
        public string ManeColor { get; set; }

        public Lion(string name = "Leo", int age = 4, double weight = 190.0, string maneColor = "Golden", bool isWild = true)
            : base(name, age, weight, isWild)
        {
            ManeColor = maneColor;
        }

        public void Roar()
        {
            Console.WriteLine($"{Name} roars: Roarrr!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} roars: Roooar!");
        }
    }
}
