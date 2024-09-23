using ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        // Skapa olika djur
        Giraffe giraffe = new Giraffe("Gina", 3, 800.0, 2.0);
        Hippo hippo = new Hippo("Harry", 10, 1500.0, 8120);
        Lion lion = new Lion("Leo", 4, 190.0, "Golden");
        AfricanLion africanLion = new AfricanLion("Simba", 5, 210.0, "Golden", true);
        AsiaticLion asiaticLion = new AsiaticLion("Ashoka", 4, 180.0, "Dark Brown", 0.5);

        // Lista för att lagra djuren
        List<Animal> animals = new List<Animal>
        {
            giraffe,
            hippo,
            lion,
            africanLion,
            asiaticLion
        };

        // Låt varje djur göra sitt ljud
        foreach (var animal in animals)
        {
            animal.MakeSound();
        }
    }
}
