namespace ConsoleApp1.Plants
{
    internal class Tree : Plant
    {
        public Tree(string name, int age, double height) : base(name, age, height)
        {
        }

        public void Photosynthesize()
        {
            Console.WriteLine($"{Name} is photosynthesizing.");
        }
    }
}
