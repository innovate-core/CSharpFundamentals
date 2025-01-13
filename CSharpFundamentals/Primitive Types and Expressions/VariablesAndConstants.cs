namespace CSharpFundamentals;

public class VariablesAndConstants
{
    public static void VariablesAndConstantsProgram()
    {
        Console.WriteLine("Start -> Variables and Constants");

        byte number = 2;
        int count = 10;
        float totalPrice = 20.95f;
        char character = 'A';
        string firstName = "Mykola";
        bool isWorking = true; //false

        Console.WriteLine(number); //Output: 2
        Console.WriteLine(count); //Output: 10
        Console.WriteLine(totalPrice); //Output: 20.95
        Console.WriteLine(character); //Output: A
        Console.WriteLine(firstName); //Output: Mykola
        Console.WriteLine(isWorking); //Output: true

        Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); //Output: 0 255
        Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue); //Output: -3.4028235E+38 3.4028235E+38

        const float Pi = 3.14f;
        //Pi = 0;

        Console.WriteLine("Finish -> Variables and Constants");
    }
}
