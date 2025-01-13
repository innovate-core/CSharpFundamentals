namespace CSharpFundamentals;

public class Strings
{
    public static void StringsProgram()
    {
        Console.WriteLine("Start -> Strings");

        var firstName = "Mykola";
        var lastname = "Maksymiv";

        var fullName = firstName + " " + lastname;

        var myFullName = string.Format("My name is {0} {1}", firstName, lastname);

        Console.WriteLine(myFullName); // Output: My name is Mykola Maksymiv

        var names = new string[3] { "Jack", "John", "Mary" };

        var formattedNames = string.Join(", ", names);

        Console.WriteLine(formattedNames); //Output: Jack, John, Mary

        var text = "Hi Mykola\nLook into the following paths \nc:\\forler1\\folder2";
        var text1 = @"Hi Mykola 
                         Look into the following paths
                         c:\forler1\folder2";

        Console.WriteLine(text);//Output: Hi Mykola Look into the following paths c:\\forler1\\folder2
        Console.WriteLine(text1); //Output: Hi Mykola            Look into the following paths       c:\\forler1\\folder2"

        Console.WriteLine("Finish -> Strings");
    }
}
