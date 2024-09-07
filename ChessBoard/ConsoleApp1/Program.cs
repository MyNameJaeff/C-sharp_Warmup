using System;

class Program
{
    static void Main(string[] args)
    {
        // Set output encoding to Unicode to display special characters like squares
        Console.OutputEncoding = System.Text.Encoding.Unicode; // Does not seem to do anything due to my terminal not allowing utf-8 characters?

        // Get the number of lines
        Console.WriteLine("How many lines? (Max 26):");
        var lineCount = Console.ReadLine()!;

        // Get the squares from the user
        Console.WriteLine("What should the white be?:");
        var white = Console.ReadLine()!; //"◻︎" Does not seem to work with theese, working on fixing
        Console.WriteLine("What should the black be?:");
        var black = Console.ReadLine()!; //"◼︎" Does not seem to work with theese, working on fixing

        // Get the piece symbol from the user
        Console.WriteLine("How do you want the piece to look?:");
        var piece = Console.ReadLine()!;

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
        var location2 = int.Parse(pieceLocation.Substring(1)); // Converts number part of the location

        // Parse line count
        var linesInt = int.Parse(lineCount);
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
                // Check if the current location is where the piece should be placed
                if (location1 == o && location2 == i)
                {
                    str += piece; // Place the piece
                }
                // Alternate between white and black squares
                else if ((i + o) % 2 == 0)
                {
                    str += white; // Place white square
                }
                else
                {
                    str += black; // Place black square
                }
            }
            Console.WriteLine(str); // Output the row
        }
    }
}
