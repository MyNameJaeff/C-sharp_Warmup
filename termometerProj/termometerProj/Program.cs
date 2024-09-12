namespace termometerProj
{
    internal class Program
    {
        static void CheckTemp()
        {
            Console.WriteLine("Ange temperaturen i Celsius (exit/x för att avsluta):");
            string message = Console.ReadLine() ?? "20";
            if (message == "exit" || message == "x") return;


            decimal temperature = Convert.ToDecimal(message);
            //Console.WriteLine((temperature >= 30) ? "Jättevarmt" : (temperature < 20) ? "Hösttemperatur" : "Varmt");

            if (temperature >= 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jättevarmt");
            }
            else if (temperature < 20)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Hösttemperatur");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Varmt");
            }
            CheckTemp();
        }
        static void Main(string[] args)
        {
            CheckTemp();
        }
    }
}
