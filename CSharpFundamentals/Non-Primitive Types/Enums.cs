namespace CSharpFundamentals;

public class Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,
    }

    public static void EnumsProgram()
    {
        Console.WriteLine("Start -> Enums");

        var method = ShippingMethod.Express;
        Console.WriteLine((int)method);

        var methodId = 3;
        Console.WriteLine((ShippingMethod)methodId);

        Console.WriteLine(method.ToString());

        var methodName = "Express";

        var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

        Console.WriteLine("Finish -> Enums");
    }
}
