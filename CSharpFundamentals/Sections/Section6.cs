using System.Globalization;
using System.Text;

namespace CSharpFundamentals.Sections;

/// <summary>
/// Working with Text
/// </summary>
public static class Section6
{
    public static void Run()
    {
        Strings();
        SummarisingText();
        StringBuilders();
    }

    private static void Strings()
    {
        Console.WriteLine("Start -> Strings");

        var fullName = "Mykola Maksymiv ";

        Console.WriteLine("Trim: '{0}'", fullName.Trim()); //Output: Trim: Mykola Maksymiv
        Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper()); //Output: ToUpper: MYKOLA MAKSYMIV

        var intex = fullName.IndexOf(' ');
        var firstName = fullName.Substring(0, intex);
        var lastName = fullName.Substring(intex + 1);

        Console.WriteLine("FirstName: " + firstName); //Output: FirstName: Mykola
        Console.WriteLine("LastName: " + lastName); //Output: LastName: Maksymiv

        var names = fullName.Split(' ');
        Console.WriteLine("FirstName: " + names[0]); //Output: FirstName: Mykola
        Console.WriteLine("LastName: " + names[1]); //Output: LastName: Maksymiv

        Console.WriteLine(fullName.Replace("Mykola", "Kolya")); //Output: Kolya Maksymiv

        if (String.IsNullOrEmpty(" ".Trim()))
            Console.WriteLine("Invalid"); //Output: Invalid

        if (String.IsNullOrWhiteSpace(" "))
            Console.WriteLine("Invalid"); //Output: Invalid

        var str = "25";
        var age = Convert.ToByte(str);
        Console.WriteLine(age); //Output: 25

        float price = 29.95f;
        Console.WriteLine(price.ToString("C0")); //Output: $30


        Console.WriteLine("Finish -> Strings");
    }

    private static void SummarisingText()
    {
        Console.WriteLine("Start -> Summarising Text");

        var sentence = "This is going to be a really really really really really long text.";
        var summary = SummerizeText(sentence, 25);
        Console.WriteLine(summary); //Output: This is going to be a really...

        Console.WriteLine("Finish -> Summarising Text");
    }

    private static string SummerizeText(string text, int maxLength = 20)
    {
        if (text.Length < maxLength)
            return text;

        var words = text.Split(' ');
        var totalCharacters = 0;
        var summaryWords = new List<string>();

        foreach (var word in words)
        {
            summaryWords.Add(word);

            totalCharacters += word.Length + 1;
            if (totalCharacters > maxLength)
                break;
        }

        return String.Join(" ", summaryWords) + "..."; ;
    }

    private static void StringBuilders()
    {
        Console.WriteLine("Start -> String Builder");

        var builder = new StringBuilder("Hello World");
        builder.Append('-', 10)
               .AppendLine()
               .Append("Header")
               .AppendLine()
               .Append('-', 10)
               .Replace('-', '+');

        builder.Remove(0, 10);

        builder.Insert(0, new string('-', 10));

        Console.WriteLine(builder);

        Console.WriteLine("First Char: " + builder[0]); //Output: First Char: -

        Console.WriteLine("Finish -> String Builder");
    }

    public static void Exercises()
    {
        Console.WriteLine("Start -> Exercises");

        Task1();
        Task2();
        Task3();
        Task4();
        Task5();

        Console.WriteLine("Finish -> Exercises");
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
