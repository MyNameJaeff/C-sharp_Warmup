namespace ConsoleApp1
{
    internal class AsiaticLion : Lion
    {
        public double ManeLength { get; set; }

        public AsiaticLion(string name = "Asiatic Leo", int age = 4, double weight = 180.0, string maneColor = "Dark Brown", double maneLength = 0.5)
            : base(name, age, weight, maneColor)
        {
            ManeLength = maneLength;
        }

        public void Rest()
        {
            Console.WriteLine($"{Name} is resting under a tree.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} roars: Roooar, but softly.");
        }
    }
}
