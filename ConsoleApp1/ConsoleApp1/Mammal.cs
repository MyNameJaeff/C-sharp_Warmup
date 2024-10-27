namespace ConsoleApp1
{
    internal abstract class Mammal : Animal
    {
        public Mammal(string name, int age, double weight, bool isWild)
            : base(name, age, weight, isWild)
        {
        }
    }
}
