namespace CSharpFundamentals;

public static class Class
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }

    public class Calcularor
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public static void ClassProgram()
    {
        Console.WriteLine("Start -> Class");

        var person = new Person();

        person.FirstName = "Mykola";
        person.LastName = "Maskymiv";
        person.Introduce();

        var calcularor = new Calcularor();

        var result = calcularor.Add(1, 2);
        Console.WriteLine(result);

        Console.WriteLine("Finish -> Class");
    }
}