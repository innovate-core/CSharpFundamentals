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

        Console.WriteLine(number);
        Console.WriteLine(count);
        Console.WriteLine(totalPrice);
        Console.WriteLine(character);
        Console.WriteLine(firstName);
        Console.WriteLine(isWorking);

        Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
        Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

        const float Pi = 3.14f;
        //Pi = 0;

        Console.WriteLine("Finish -> Variables and Constants");
    }
}
