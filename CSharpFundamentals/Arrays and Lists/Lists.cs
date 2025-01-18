namespace CSharpFundamentals;

public class Lists
{
    public static void ListsProgram()
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
}
