namespace CSharpFundamentals;

public class ReferenceTypesAndValueTypes
{
    public class Person
    {
        public int Age;
    }

    public static void ReferenceTypesAndValueTypesProgram()
    {
        Console.WriteLine("Start -> Reference Types and Value Types");

        var a = 10;
        var b = a;
        b++;

        Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); //Output a : 10, b: 11

        var array1 = new int[3] { 1, 2, 3 };
        var array2 = array1;
        array2[0] = 0;

        Console.WriteLine(string.Format("array1[0]: {0}, array[0] : {1}", array1[0], array2[0])); //Output: "array1[0]: 0, array[0] : 0

        var number = 1;
        Increment(number);
        Console.WriteLine(number); //Output: 1

        var person = new Person() { Age = 20 };
        MakeOld(person);
        Console.WriteLine(person.Age);  //Output: 30

        Console.WriteLine("Finish -> Reference Types and Value Types");
    }

    public static void Increment(int number)
    {
        number += 10;
    }

    public static void MakeOld(Person person)
    {
        person.Age += 10;
    }
}
