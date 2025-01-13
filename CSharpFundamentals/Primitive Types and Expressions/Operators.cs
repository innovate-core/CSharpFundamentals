namespace CSharpFundamentals;

public class Operators
{
    public static void OperatorsProgram()
    {
        Console.WriteLine("Start -> Operators");

        int a = 10;
        int b = 3;
        int c = 5;

        Console.WriteLine(a + b); //Output: 13
        Console.WriteLine(a / b); //Output: 3
        Console.WriteLine((float)a / (float)b); //Output: 3.333
        Console.WriteLine(a + b * c); //Output: 25


        Console.WriteLine(a > b); //Output: True
        Console.WriteLine(a == b); //Output: False
        Console.WriteLine(!(a == b)); //Output: True

        Console.WriteLine("Finish -> Operators");
    }
}
