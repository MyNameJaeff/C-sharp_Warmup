namespace TheConsoleLottery;

class Program
{
    static void Main()
    {
        static int[] GetUserInputs(int playerWallet)
        {
            Console.WriteLine($"Plånbok: {playerWallet}");

            int ticketAmount;
            do
            {
                Console.WriteLine("Hur många lotter vill du köpa?");
                bool isValid = int.TryParse(Console.ReadLine(), out ticketAmount);
                if (!isValid)
                {
                    Console.WriteLine("Ogiltig inmatning! Försök igen.");
                }
                else
                {
                    if (ticketAmount > playerWallet)
                    {
                        Console.WriteLine("Du har inte tillräckligt med pengar! Försök igen.");
                    }
                    else if (ticketAmount <= 0)
                    {
                        Console.WriteLine("Du måste ange ett positivt antal lotter.");
                    }
                }
            } while (ticketAmount > playerWallet || ticketAmount <= 0);

            int[] playerInputs = new int[ticketAmount];
            for (int i = 0; i < ticketAmount; i++)
            {
                int userInput;
                do
                {
                    Console.WriteLine($"Lott {i + 1}. Ange ett nummer mellan 1 och 50:");
                    bool isValid = int.TryParse(Console.ReadLine(), out userInput);
                    if (!isValid)
                    {
                        Console.WriteLine("Ogiltig inmatning! Försök igen.");
                    }
                    else
                    {
                        if (userInput < 1 || userInput > 50)
                        {
                            Console.WriteLine("Numret måste vara mellan 1 och 50. Försök igen.");
                        }

                    }
                } while (userInput < 1 || userInput > 50);

                playerInputs[i] = userInput;
            }

            return playerInputs;
        }

        static int[] GetWinningNumbers()
        {
            int[] winningNumbers = new int[3];
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                winningNumbers[i] = random.Next(1, 51);
            }

            return winningNumbers;
        }

        static void CheckIfWinner(int playerWallet)
        {
            bool wonSomething = false;
            int[] userNumbers = GetUserInputs(playerWallet);
            int[] winningNumbers = GetWinningNumbers();
            playerWallet -= userNumbers.Length; // Varje lott kostar 1

            Console.Write("Vinnande nummer var: ");
            foreach (int winningNumber in winningNumbers)
            {
                Console.Write($"{winningNumber} ");
            }

            Console.WriteLine(); // Skapar radbrytning

            foreach (int winningNumber in winningNumbers)
            {
                foreach (int userNumber in userNumbers)
                {
                    if (userNumber == winningNumber)
                    {
                        playerWallet += 5; // Vinst ger 5 tillbaka till plånboken
                        wonSomething = true;
                        Console.WriteLine($"Grattis! {userNumber} var ett vinnande nummer!");
                    }
                }
            }

            if (!wonSomething)
            {
                Console.WriteLine("Du vann ingenting! Synd!");
            }

            Console.WriteLine($"Plånbok: {playerWallet}");
            CheckIfReplay(playerWallet);
        }

        static void CheckIfReplay(int playerWallet)
        {
            if (playerWallet == 0)
            {
                Console.WriteLine("Du har inga pengar kvar! Kan inte spela igen!");
            }
            else
            {
                Console.WriteLine("\nVill du spela igen? (y/n)");
                if (Console.ReadLine()?.ToLower() == "y")
                {
                    Console.Clear();
                    CheckIfWinner(playerWallet);
                }
                else
                {
                    Console.WriteLine("Hejdå!");
                }
            }
        }

        int playerWallet = 15;
        CheckIfWinner(playerWallet);
    }
}