namespace ConsoleApp1.Animals.Reptiles
{
    internal abstract class Reptile : Animal
    {
        public Reptile(string name, int age, double weight, bool isWild)
            : base(name, age, weight, isWild)
        {
        }
    }
}
