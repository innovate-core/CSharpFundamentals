namespace CSharpFundamentals
{
    public class Exercises
    {
        public static void ExercisesProgram()
        {
            Console.WriteLine("Start -> Exercises");

            Task1();
            Task2();
            Task3();
            Task4();
            Task5();

            Console.WriteLine("Finish -> Exercises");
        }

        //Task 1
        //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
        //Display the count on the console 
        public static void Task1()
        {
            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }

            Console.WriteLine("The count of numbers between 1 and 100 that are divisible by 3 is: {0}", count);
        }

        //Write a program and continuously ask the user to enter a number or "ok" to exit.
        //Calculate the sum of all the previously entered numbers and display it on the console.
        public static void Task2()
        {
            var stopKey = "OK";
            var sum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number (or type 'ok' to exit):");
                var input = Console.ReadLine();

                if (input?.ToLower() == stopKey.ToLower())
                    break;

                if (int.TryParse(input, out int number))
                    sum += number;
                else
                    Console.WriteLine("Invalid input. Please enter a valid number or 'ok' to exit.");
            }

            Console.WriteLine($"The sum of all entered numbers is: {sum}");
        }

        // Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
        // For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        public static void Task3()
        {
            Console.WriteLine("Enter a number to calculate its factorial:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= 0)
            {
                long factorial = 1;

                for (int i = 1; i <= number; i++)
                    factorial *= i;

                Console.WriteLine($"{number}! = {factorial}");
            }
            else
            {
                Console.WriteLine("Please enter a valid non-negative integer.");
            }
        }

        //Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
        //If the user guesses the number, display “You won"; otherwise, display “You lost".
        //(To make sure the program is behaving correctly, you can display the secret number on the console first.)
        public static void Task4()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 11); // Random number between 1 and 10
            int attempts = 4;
            bool isGuessed = false;

            Console.WriteLine($"(Debug Info: The secret number is {secretNumber})"); // Debugging purpose only

            Console.WriteLine("Guess the number (between 1 and 10):");

            for (int i = 0; i < attempts; i++)
            {
                Console.Write($"Attempt {i + 1}/{attempts}: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int guess))
                {
                    if (guess == secretNumber)
                    {
                        Console.WriteLine("You won!");
                        isGuessed = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong guess, try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
                }
            }

            if (!isGuessed)
                Console.WriteLine("You lost! Better luck next time.");
        }

        //Write a program and ask the user to enter a series of numbers separated by comma.
        //Find the maximum of the numbers and display it on the console.
        //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        public static void Task5()
        {
            Console.WriteLine("Enter a series of numbers separated by commas (e.g., 5,3,8,1,4):");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                try
                {
                    var numbers = input.Split(',')
                                       .Select(number => int.Parse(number.Trim()))
                                       .ToList();

                    int maxNumber = numbers.Max();

                    Console.WriteLine($"The maximum number is: {maxNumber}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numbers separated by commas.");
                }
            }
            else
            {
                Console.WriteLine("Input cannot be empty. Please try again.");
            }
        }
    }
}