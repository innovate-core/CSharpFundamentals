namespace CSharpFundamentals.Text;

public class Strings
{
    public static void StringsProgram()
    {
        Console.WriteLine("Start -> Strings");

        var fullName = "Mykola Maksymiv ";

        Console.WriteLine("Trim: '{0}'", fullName.Trim()); //Output: Trim: Mykola Maksymiv
        Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper()); //Output: ToUpper: MYKOLA MAKSYMIV

        var intex = fullName.IndexOf(' ');
        var firstName = fullName.Substring(0, intex);
        var lastName = fullName.Substring(intex + 1);

        Console.WriteLine("FirstName: " + firstName); //Output: FirstName: Mykola
        Console.WriteLine("LastName: " + lastName); //Output: LastName: Maksymiv

        var names = fullName.Split(' ');
        Console.WriteLine("FirstName: " + names[0]); //Output: FirstName: Mykola
        Console.WriteLine("LastName: " + names[1]); //Output: LastName: Maksymiv

        Console.WriteLine(fullName.Replace("Mykola", "Kolya")); //Output: Kolya Maksymiv

        if (String.IsNullOrEmpty(" ".Trim()))
            Console.WriteLine("Invalid"); //Output: Invalid

        if (String.IsNullOrWhiteSpace(" "))
            Console.WriteLine("Invalid"); //Output: Invalid

        var str = "25";
        var age = Convert.ToByte(str);
        Console.WriteLine(age); //Output: 25

        float price = 29.95f;
        Console.WriteLine(price.ToString("C0"));


        Console.WriteLine("Finish -> Strings");
    }
}
