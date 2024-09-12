class Program
{
    private static void Main(string[] args)
    {
        // Set output encoding to Unicode to display special characters like squares
        Console.OutputEncoding = System.Text.Encoding.Unicode; // Does not seem to do anything due to my terminal not allowing utf-8 characters?

        // Get the number of lines
        Console.WriteLine("How many lines? (Max 26):");
        var lineCount = Console.ReadLine()!;

        string white; string black; string piece;

        Console.WriteLine("Do you want custom stuff? (y/n):");
        if (Console.ReadLine() == "y")
        {
            // Get the squares from the user
            Console.WriteLine("What should the white be?:");
            white = Console.ReadLine()!;
            Console.WriteLine("What should the black be?:");
            black = Console.ReadLine()!;
            Console.WriteLine("How do you want the piece to look?:");
            piece = Console.ReadLine()!;
        }
        else
        {
            white = "◻︎";
            black = "◼︎";
            piece = "🙂";
        }

        // Get the piece location
        Console.WriteLine("Where do you want to place the piece? (A-Z & Max 26):");
        var pieceLocation = Console.ReadLine()!;

        // Function to check if a string is null or empty
        static bool checkString(string str)
        {
            return string.IsNullOrEmpty(str);
        }

        // Check for null or empty values in the inputs
        if (checkString(lineCount) || checkString(piece) || checkString(pieceLocation))
        {
            Console.WriteLine("Some value is null/empty, please try again!");
            return;
        }

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