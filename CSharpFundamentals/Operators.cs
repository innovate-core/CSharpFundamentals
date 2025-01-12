namespace CSharpFundamentals;

public class Operators
{
    public static void OperatorsProgram()
    {
        Console.WriteLine("Start -> Operators");

        int a = 10;
        int b = 3;
        int c = 5;

        Console.WriteLine(a + b);
        Console.WriteLine(a / b);
        Console.WriteLine((float)a / (float)b);
        Console.WriteLine(a + b * c);


        Console.WriteLine(a > b);
        Console.WriteLine(a == b);
        Console.WriteLine(!(a == b));

        Console.WriteLine("Finish -> Operators");
    }
}
