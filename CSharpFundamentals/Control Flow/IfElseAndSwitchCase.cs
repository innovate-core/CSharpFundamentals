namespace CSharpFundamentals
{
    public class IfElseAndSwitchCase
    {
        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        public static void IfElseAndSwitchCaseProgram()
        {
            Console.WriteLine("Start -> If\\Else and Switch\\Case");

            int hour = 10;

            if (hour > 0 && hour < 12)
                Console.WriteLine("It's morning."); //Output: It's morning.
            else if (hour >= 12 && hour < 18)
                Console.WriteLine("It's afternoon.");
            else
                Console.WriteLine("It's evening.");

            bool isGoldCustomer = true;
            float price;

            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;

            Console.WriteLine(price); //Output: 19.95

            float cost = isGoldCustomer ? 12.45f : 15.32f;
            Console.WriteLine(cost); //Output: 12.45f

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful seasen."); //Output: It's autumn and a beautiful seasen.
                    break;

                case Season.Summer:
                    Console.WriteLine("It`s perfect to go to beach.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }

            Console.WriteLine("Finish -> If\\Else and Switch\\Case");
        }
    }
}
