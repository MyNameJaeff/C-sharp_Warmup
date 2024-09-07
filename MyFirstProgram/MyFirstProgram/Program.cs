// Fredrik Andersson .NET24
int number = 11;

if(number > 10) // Kollar ifall satt tal är större än 10, ifall det inte är det så skriv ut att det är lågt tal
{
    Console.WriteLine("Talet är stort!");
}
else
{
    Console.WriteLine("Oj. Lågt tal!");
}

Console.WriteLine("Vad heter du?"); // Skriver ut en fråga som sedan tar emot ett svar som en sträng: "namn" som sedan anväds för att säga "Hej namn!"
string namn = Console.ReadLine() ?? "Namn";
Console.WriteLine("Hej " + namn + "!");

for(int o = 0; o <= number; o++) // Skriver ut alla tal mellan 0 - tidigare tal
{
    Console.WriteLine(o);
}
