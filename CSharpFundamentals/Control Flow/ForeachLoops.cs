namespace CSharpFundamentals;

public class ForeachLoops
{
    public static void ForeachLoopsProgram()
    {
        Console.WriteLine("Start -> Foreach Loops");

        var name = "Mykola Maksymiv";

        //for (int i = 0; i < name.Length; i++)
        //{
        //    Console.WriteLine(name[i]);
        //}

        foreach(var character in name)
        {
            Console.WriteLine(character); // Output: M y k o l a   M a k s y m i v
        }

        var numbers = new int[] { 1, 2, 3, 4, 5 };

        foreach (var number in numbers)
        {
            Console.WriteLine(number); //Output: 1 2 3 4 5
        }

        Console.WriteLine("Start -> Foreach Loops");
    }
}
