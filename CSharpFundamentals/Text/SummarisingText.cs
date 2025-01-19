namespace CSharpFundamentals.Text;

public class SummarisingText
{
    public static void SummarisingTextProgram()
    {
        Console.WriteLine("Start -> Summarising Text");

        var sentence = "This is going to be a really really really really really long text.";
        var summary = StringUtility.SummerizeText(sentence, 25);
        Console.WriteLine(summary); //Output: This is going to be a really...

        Console.WriteLine("Finish -> Summarising Text");
    }
}
