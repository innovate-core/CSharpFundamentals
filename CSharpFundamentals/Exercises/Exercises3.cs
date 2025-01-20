
using System.Globalization;

namespace CSharpFundamentals;

public class Exercises3
{
    public static void ExercisesProgram()
    {
        Console.WriteLine("Start -> Exercises 3");

        Task1();
        Task2();
        Task3();
        Task4();
        Task5();

        Console.WriteLine("Finish -> Exercises 3");
    }

    /// <summary>
    /// Write a program and ask the user to enter a few numbers separated by a hyphen.
    /// Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
    /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
    /// </summary>
    private static void Task1()
    {
        // Check if the numbers are consecutive
        bool areConsecutiveAscending = true;
        bool areConsecutiveDescending = true;

        Console.WriteLine("Enter a few numbers separated by a hyphen (e.g., 5-6-7-8-9):");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid input. Please enter some numbers.");
            return;
        }

        // Split the input and convert it to an array of integers
        int[] numbers = input.Split('-').Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] + 1 != numbers[i + 1])
                areConsecutiveAscending = false;

            if (numbers[i] - 1 != numbers[i + 1])
                areConsecutiveDescending = false;
        }

        if (areConsecutiveAscending || areConsecutiveDescending)
            Console.WriteLine("Consecutive");
        else
            Console.WriteLine("Not Consecutive");
    }

    /// <summary>
    /// Write a program and ask the user to enter a few numbers separated by a hyphen.
    /// If the user simply presses Enter, without supplying an input, exit immediately;
    /// otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
    /// </summary>
    private static void Task2()
    {
        while (true)
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen (or press Enter to exit):");
            string input = Console.ReadLine();

            // Exit if the user presses Enter without input
            if (string.IsNullOrWhiteSpace(input))
                break;

            // Split the input into numbers and check for duplicates
            var numbers = input.Split('-').Select(x => x.Trim()).ToList();

            if (numbers.Distinct().Count() != numbers.Count)
                Console.WriteLine("Duplicate");
        }
    }

    /// <summary>
    /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
    /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok";
    /// otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
    /// </summary>
    private static void Task3()
    {
        Console.WriteLine("Enter a time value in the 24-hour format (e.g., 19:00):");
        string input = Console.ReadLine();

        // Check if input is empty or null
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid Time");
            return;
        }

        // Validate the time format
        if (TimeSpan.TryParse(input, out TimeSpan time))
        {
            if (time >= TimeSpan.FromHours(0) && time < TimeSpan.FromHours(24))
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }
        else
        {
            Console.WriteLine("Invalid Time");
        }
    }

    /// <summary>
    /// Write a program and ask the user to enter a few words separated by a space.
    /// Use the words to create a variable name with PascalCase. For example, if the user types: "number of students",
    /// display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS",
    /// the program should still display "NumberOfStudents"
    /// </summary>
    private static void Task4()
    {
        Console.WriteLine("Enter a few words separated by a space (e.g., 'number of students'):");
        string input = Console.ReadLine();

        // Check if input is empty or null
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No input provided.");
            return;
        }

        // Split the input into words, convert to PascalCase, and concatenate
        TextInfo textInfo = CultureInfo.InvariantCulture.TextInfo;
        string result = string.Join("", input
            .ToLowerInvariant()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(word => textInfo.ToTitleCase(word)));

        Console.WriteLine($"PascalCase: {result}");
    }

    /// <summary>
    /// Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word.
    /// So, if the user enters "inadequate", the program should display 6 on the console.
    /// </summary>
    private static void Task5()
    {
        Console.WriteLine("Enter an English word:");
        string input = Console.ReadLine();

        // Check if the input is null or empty
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Please enter a valid word.");
            return;
        }

        // Initialize vowel count
        int vowelCount = 0;

        // Convert the input to lowercase to make the comparison case-insensitive
        input = input.ToLower();

        // Iterate through each character and count vowels
        foreach (char c in input)
        {
            if ("aeiou".Contains(c))  // Check if the character is a vowel
                vowelCount++;
        }

        // Display the result
        Console.WriteLine($"Number of vowels: {vowelCount}");
    }
}
