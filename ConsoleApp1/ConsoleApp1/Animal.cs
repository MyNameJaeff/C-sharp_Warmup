namespace ConsoleApp1
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Species { get; set; }
        public bool IsAlive { get; private set; }
        public Animal(string name, int age, double weight, string species)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Species = species;
            IsAlive = true;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
            Weight += 0.5;
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

        public void Die()
        {
            IsAlive = false;
            Console.WriteLine($"{Name} has died.");
        }
        public virtual void MakeSound() 
        {
            Console.WriteLine("Animal sound.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Weight: {Weight} kg, Species: {Species}, Alive: {IsAlive}");
        }
    }
}
