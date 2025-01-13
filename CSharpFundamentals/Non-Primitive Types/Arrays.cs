namespace CSharpFundamentals;

public class Arrays
{
    public static void ArraysProgram()
    {
        Console.WriteLine("Start -> Arrays");

        var numbers = new int[3];
        numbers[0] = 1;

        Console.WriteLine(numbers[0]); //Output: 1
        Console.WriteLine(numbers[1]); //Output: 0
        Console.WriteLine(numbers[2]); //Output: 0

        var flags = new bool[3];
        flags[0] = true;

        Console.WriteLine(flags[0]); //Output: True
        Console.WriteLine(flags[1]); //Output: False
        Console.WriteLine(flags[2]); //Output: False

        var names = new string[3] { "Jack", "John", "Mary" };

        Console.WriteLine(names[0]); //Output: Jack

        Console.WriteLine("Finish -> Arrays");
    }
}
