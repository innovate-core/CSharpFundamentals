namespace CSharpFundamentals.Sections;

/// <summary>
/// Arrays and Lists
/// </summary>
public static class Section4
{
    public static void Run()
    {
        Arrays();
        Lists();
    }

    private static void Arrays()
    {
        Console.WriteLine("Start -> Arrays");

        var numbers = new[] { 3, 7, 9, 2, 14, 6 };

        //Lenght
        Console.WriteLine("Lenght: {0}", numbers.Length); //Output:Lenght: 6

        //IndexOf()
        var index = Array.IndexOf(numbers, 9);
        Console.WriteLine("Index of 9: {0}", index); //Output: Index of 9: 2

        //Clear()
        Array.Clear(numbers, 0, 2);

        Console.WriteLine("Effect of Clear()");

        foreach (var n in numbers)
            Console.WriteLine(n); //Output: 0 0 9 2 14 6

        //Copy()
        int[] another = new int[3];
        Array.Copy(numbers, another, 3);

        Console.WriteLine("Effect of Copy()");

        foreach (var n in another)
            Console.WriteLine(n); //Output: 0 0 9

        //Sort()
        Array.Sort(numbers);

        Console.WriteLine("Effect of Sort()");

        foreach (var n in numbers)
            Console.WriteLine(n); //Output: 0 0 2 6 9 14

        //Reverse()
        Array.Reverse(numbers);

        Console.WriteLine("Effect of Reverse()");

        foreach (var n in numbers)
            Console.WriteLine(n); //Output: 14 9 6 2 0 0

        Console.WriteLine("Finish -> Arrays");
    }

    private static void Lists()
    {
        var numbers = new List<int>() { 1, 2, 3, 4 };

        numbers.Add(1);
        numbers.AddRange(new int[3] { 5, 6, 7 });

        foreach (int number in numbers)
            Console.WriteLine(number); //Output: 1 2 3 4 1 5 6 7

        Console.WriteLine();
        Console.WriteLine("Index of 1: " + numbers.IndexOf(1)); //Output: Index of 1: 0
        Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1)); //Output: Last Index of 1: 4

        Console.WriteLine("Count: " + numbers.Count);//Output: Count: 8

        numbers.Remove(1);
        foreach (int number in numbers)
            Console.WriteLine(number); //Output: 2 3 4 1 5 6 7

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == 1)
                numbers.Remove(numbers[i]);
        }

        foreach (int number in numbers)
            Console.WriteLine(number); //Output: 2 3 4 5 6 7

        numbers.Clear();

        Console.WriteLine("Count: " + numbers.Count);//Output: Count: 0
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
    /// When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
    ///     -> If no one likes your post, it doesn't display anything.
    ///     -> If only one person likes your post, it displays: [Friend's Name] likes your post.
    ///     -> If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
    ///     -> If more than two people like your post, it displays: [Friend 1], [Friend 2] 
    ///         and [Number of Other People] others like your post.
    /// Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
    /// Depending on the number of names provided, display a message based on the above pattern.
    /// </summary>
    private static void Task1()
    {
        var names = new List<string>();
        Console.WriteLine("Enter names of people who like your post (press Enter without typing a name to finish):");

        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                break;

            names.Add(input);
        }

        if (names.Count == 0)
            Console.WriteLine("No one likes your post.");
        else if (names.Count == 1)
            Console.WriteLine($"{names[0]} likes your post.");
        else if (names.Count == 2)
            Console.WriteLine($"{names[0]} and {names[1]} like your post.");
        else
            Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post.");
    }

    /// <summary>
    /// Write a program and ask the user to enter their name.
    /// Use an array to reverse the name and then store the result in a new string.
    /// Display the reversed name on the console.
    /// </summary>
    private static void Task2()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        if (!string.IsNullOrEmpty(name))
        {
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            string reversedName = new string(nameArray);

            Console.WriteLine($"Your name reversed is: {reversedName}");
        }
        else
        {
            Console.WriteLine("You did not enter a name.");
        }
    }

    /// <summary>
    /// Write a program and ask the user to enter 5 numbers.
    /// If a number has been previously entered, display an error message and ask the user to re-try.
    /// Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
    /// </summary>
    private static void Task3()
    {
        var numbers = new List<int>();

        Console.WriteLine("Enter 5 unique numbers:");

        while (numbers.Count < 5)
        {
            Console.Write($"Enter number {numbers.Count + 1}: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (numbers.Contains(number))
                    Console.WriteLine("This number has already been entered. Please enter a different number.");
                else
                    numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        numbers.Sort();
        Console.WriteLine("The sorted numbers are: " + string.Join(", ", numbers));
    }

    /// <summary>
    /// Write a program and ask the user to continuously enter a number or type "Quit" to exit.
    /// The list of numbers may include duplicates.
    /// Display the unique numbers that the user has entered.
    /// </summary>
    private static void Task4()
    {
        var numbers = new HashSet<int>();
        Console.WriteLine("Enter numbers continuously. Type 'Quit' to exit.");

        while (true)
        {
            Console.Write("Enter a number or 'Quit': ");
            string input = Console.ReadLine();

            if (input.Equals("Quit", StringComparison.OrdinalIgnoreCase))
                break;

            if (int.TryParse(input, out int number))
                numbers.Add(number); // HashSet automatically handles duplicates
            else
                Console.WriteLine("Invalid input. Please enter a valid number or 'Quit' to exit.");
        }

        Console.WriteLine("Unique numbers entered: " + string.Join(", ", numbers));
    }

    /// <summary>
    /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
    /// If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
    /// otherwise, display the 3 smallest numbers in the list.
    /// </summary>
    private static void Task5()
    {
        while (true)
        {
            Console.WriteLine("Enter a list of comma-separated numbers (e.g., 5, 1, 9, 2, 10):");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                var numbers = input.Split(',')
                                   .Select(number => int.TryParse(number.Trim(), out int n) ? n : (int?)null)
                                   .Where(n => n.HasValue)
                                   .Select(n => n.Value)
                                   .ToList();

                if (numbers.Count >= 5)
                {
                    var smallestNumbers = numbers.OrderBy(n => n).Take(3);
                    Console.WriteLine("The 3 smallest numbers are: " + string.Join(", ", smallestNumbers));
                    break;
                }
            }

            Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
        }
    }
}