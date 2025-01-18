namespace CSharpFundamentals;

public class RandomClass
{
    public static void RandomClassProgram()
    {
        Console.WriteLine("Start -> Random class");

        var random = new Random();

        const int passwordLength = 10;

        var buffer = new char[passwordLength];

        for (int i = 0; i < passwordLength; i++)
            buffer[i] = (char)('a' + random.Next(0, 26));

        var password = new string(buffer);

        Console.WriteLine(password); //Output: random string

        Console.WriteLine("Finish -> Random class");
    }
}
