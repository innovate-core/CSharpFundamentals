namespace CSharpFundamentals;

public class ForLoops
{
    public static void ForLoopsProgram()
    {
        Console.WriteLine("Start ->  For Loops");

        for (var i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i); //Output: 2 4 6 8 10
            }
        }

        for (var i = 10; i >= 1; i--)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i); //Output: 10 8 6 4 2
            }
        }
        Console.WriteLine("Finish ->  For Loops");
    }
}