namespace ConsoleApp1
{
    internal class AfricanLion : Lion
    {
        public bool IsLeader { get; set; }

        public AfricanLion(string name = "African Leo", int age = 4, double weight = 190.0, string maneColor = "Golden", bool isLeader = false)
            : base(name, age, weight, maneColor)
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
