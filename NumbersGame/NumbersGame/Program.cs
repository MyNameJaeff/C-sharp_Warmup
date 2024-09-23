namespace NumbersGame
{
    internal class Program
    {
        static bool CheckGuess(int generatedNumber, int guessedNr)
        {
            Random random = new Random();
            string[] highReplies = { "För högt!", "Nästan, men för högt!", "Lite för högt!" };
            string[] lowReplies = { "För lågt!", "Nästan, men för lågt!", "Lite för lågt!" };
            string[] closeReplies = { "Det bränns!", "Nästan rätt!", "Mycket nära!" };
            string[] farReplies = { "Oj, långt ifrån!", "Kallt!", "Inte ens nära." };

            int difference = Math.Abs(generatedNumber - guessedNr);

            if (guessedNr == generatedNumber)
            {
                return true;
            }

            Console.WriteLine(difference == 1 ? closeReplies[random.Next(closeReplies.Length)] :
                              difference <= 3 ? "Du är nära!" :
                              farReplies[random.Next(farReplies.Length)]);

            Console.WriteLine((guessedNr < generatedNumber)
                ? lowReplies[random.Next(lowReplies.Length)]
                : highReplies[random.Next(highReplies.Length)]);

            return false;
        }

        static void HandleGame()
        {
            Console.WriteLine("Välkommen! Välj svårighetsgrad (1-5):");
            if (int.TryParse(Console.ReadLine(), out int difficulty) && difficulty >= 1 && difficulty <= 5)
            {
                Random random = new Random();
                int[] guessesArray = { 10, 6, 5, 3, 1 };
                int[] numbersArray = { 20, 15, 15, 20, 20 };
                int guesses = guessesArray[difficulty - 1];
                int generatedNumber = random.Next(1, numbersArray[difficulty - 1]);
                bool correctGuess = false;

                Console.WriteLine($"Gissa på ett nummer mellan 1-{numbersArray[difficulty - 1]}");

                while (guesses > 0 && !correctGuess)
                {
                    Console.Write($"Du har {guesses} försök kvar. Gissa ett tal: ");
                    if (int.TryParse(Console.ReadLine(), out int guessedNr))
                    {
                        correctGuess = CheckGuess(generatedNumber, guessedNr);
                        guesses--;

                        if (correctGuess)
                        {
                            Console.WriteLine("Grattis! Du gissade rätt.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ogiltig inmatning. Ange ett giltigt tal.");
                    }
                }

                if (!correctGuess)
                {
                    Console.WriteLine($"Tyvärr, du har slut på försök! Det rätta numret var {generatedNumber}.");
                }
            }
            else
            {
                Console.WriteLine("Ogiltig svårighetsgrad. Försök igen.");
            }
        }

        static bool AskReplay()
        {
            Console.WriteLine("Vill du spela igen? (y/n)");
            string replayAnswer = Console.ReadLine()?.ToLower();
            if (replayAnswer == "y") Console.Clear();
            return replayAnswer == "y";
        }

        static void Main(string[] args)
        {
            do
            {
                HandleGame();
            } while (AskReplay());

            Console.WriteLine("Tack för att du spelade!");
        }
    }
}
