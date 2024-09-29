using System.Text;

class Program
{
    private static void Main(string[] args)
    {
        // Function to check so that no input is empty
        string GetValidInput(string prompt)
        {
            string input;
            do
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Felaktig input, försök igen!.");
                }
            } while (string.IsNullOrWhiteSpace(input));

            return input;
        }

        int GetValidNumber(string prompt, int max)
        {
            int number;
            while (!int.TryParse(GetValidInput(prompt), out number) || number < 1 || number > max)
            {
                Console.WriteLine($"Ange ett nummer mellan 1 och {max}.");
            }
            return number;
        }

        // Set output and input encoding to Unicode to display special characters like squares or emojis
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        // Get the number of lines
        int lineCount = GetValidNumber("How many lines? (Max 26):", 26); // Max 26 because of the alphabet needed to place the piece
        string white; string black; string piece;

        Console.WriteLine("Do you want custom stuff? (y/n):");
        if (Console.ReadLine() == "y")
        {
            white = GetValidInput("What should the white be? (Please enter a valid value):");
            black = GetValidInput("What should the black be? (Please enter a valid value):");
            piece = GetValidInput("How do you want the piece to look? (Please enter a valid value):");
        }
        else
        {
            white = "◻︎";
            black = "◼︎";
            piece = "🙂";
        }

        // Get the piece location
        var pieceLocation = GetValidInput("Where do you want to place the piece? (A-Z & Max 26):");

        // Determine the location of the piece based on letter and number
        var location1 = char.ToUpper(pieceLocation[0]) - 64; // Converts letter A-Z to a number 1-26
        var location2 = Convert.ToInt32(pieceLocation.Substring(1)); // Converts number part of the location

        // Converts the string to int
        var linesInt = Convert.ToInt32(lineCount);
        if (linesInt > 26)
        {
            Console.WriteLine("You can't have more than 26 lines!");
            return;
        }

        // Generate the grid
        for (var i = 1; i <= linesInt; i++)
        {
            var str = "";
            for (var o = 1; o <= linesInt; o++)
            {
                str += (location1 == o && location2 == i) ? piece : (i + o) % 2 == 0 ? white : black;
            }
            Console.WriteLine(str); // Output the row
        }
    }
}