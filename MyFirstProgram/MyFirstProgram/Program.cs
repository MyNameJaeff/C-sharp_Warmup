// Fredrik Andersson .NET24
int number = 11;

// Checks if the number is greater than 10, otherwise a message is displayed that the number is low
Console.WriteLine((number > 10) ? "Talet är stort!" : "Oj, lågt tal!");

// Asks the user for their name and then greets them
Console.WriteLine("Vad heter du?");
string name = Console.ReadLine() ?? "Namn";
Console.WriteLine($"Hej {name}!");

// Prints all numbers between 0 and the chosen number
for (int o = 0; o <= number; o++)
{
    Console.WriteLine(o);
}
