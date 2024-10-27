namespace ConsoleApp1.Animals.Mammals.Lions
{
    internal class AfricanLion : Lion
    {
        public bool IsLeader { get; set; }

        public AfricanLion(string name = "African Leo", int age = 4, double weight = 190.0, string maneColor = "Golden", bool isWild = true, bool isLeader = false)
            : base(name, age, weight, maneColor, isWild)
        {
            IsLeader = isLeader;
        }

        public void Hunt()
        {
            Console.WriteLine($"{Name} is hunting.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} roars: Roarrr, I'm the king!");
        }
    }
}
