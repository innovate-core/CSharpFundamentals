namespace CSharpFundamentals;

public class TypeConversion
{
    public static void TypeConversionProgram()
    {
        Console.WriteLine("Start -> Type Conversion");

        byte b = 1;
        int i = b;
        Console.WriteLine(i); //Output: 1

        int i1 = 1000;
        byte b1 = (byte)i1;
        Console.WriteLine(b1);//Output: 232

        var number = "1234";
        int i2 = Convert.ToInt32(number);
        Console.WriteLine(i2); //Output: 1234

        try
        {
            var number1 = "1234";
            byte b2 = Convert.ToByte(number1); //Error
            Console.WriteLine(b2);
        }
        catch (Exception)
        {
            Console.WriteLine("The number could not be converted to a byte."); //Output: The number could not be converted to a byte.
        }

        try
        {
            var str = "true";
            bool b3  = Convert.ToBoolean(str);
            Console.WriteLine(b3); //Output: True
        }
        catch (Exception)
        {
        }


        Console.WriteLine("Finish -> Type Conversion");
    }
}