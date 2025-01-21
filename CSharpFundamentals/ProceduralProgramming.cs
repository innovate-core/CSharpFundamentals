namespace CSharpFundamentals;

public class ProceduralProgramming
{
    public static void ProceduralProgrammingProgram()
    {
        Console.WriteLine("Start -> Procedural Programming");

        string[] elements;

        while (true)
        {
            Console.Write("Enter a list of comma-seperated numbers: ");
            var input = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(input))
            {
                elements = input.Split(',');

                if (elements.Length >= 5)
                    break;
            }

            Console.WriteLine("Invalid List");
        }

        var numbers = new List<int>();

        foreach (var number in elements)
            numbers.Add(Convert.ToInt32(number));

        var smallests = new List<int>();

        while (smallests.Count < 3)
        {
            // Assume the first number is the smallest
            var min = numbers[0];

            foreach (var number in numbers)
            {
                if (number < min)
                    min = number;
            }

            smallests.Add(min);
            numbers.Remove(min);
        }

        Console.WriteLine("The 3 smallest numbers are: ");
        foreach (var number in smallests)
            Console.WriteLine(number);



        Console.Write("What's your name? ");
        var name = Console.ReadLine();
        var reversed = ReverseName(name);
        Console.WriteLine("Reversed: " + reversed);

        Console.WriteLine("Finish -> Procedural Programming");
    }

    private static string ReverseName(string name)
    {
        var array = new char[name.Length];
        
        for (var i = name.Length; i > 0; i--)
            array[name.Length - 1] = name[i - 1];

        return new string(array);
    }
}