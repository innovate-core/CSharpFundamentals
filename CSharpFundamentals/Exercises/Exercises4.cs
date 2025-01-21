
namespace CSharpFundamentals
{
    public class Exercises4
    {
        public static void Exercises4Program()
        {
            Console.WriteLine("Start -> Exercises 4");

            Task1();
            Task2();

            Console.WriteLine("Finish -> Exercises 4");
        }

        /// <summary>
        /// Write a program that reads a text file and displays the number of words.
        /// </summary>
        private static void Task1()
        {
            try
            {
                string filePath = @"d:\test";

                // Check if the file exists
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File does not exist.");
                    return;
                }

                // Read all text from the file
                string content = File.ReadAllText(filePath);

                // Split the content into words
                string[] words = content.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                // Count the words
                int wordCount = words.Length;

                // Display the result
                Console.WriteLine($"The file contains {wordCount} word(s).");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Write a program that reads a text file and displays the longest word in the file.
        /// </summary>
        private static void Task2()
        {
            try
            {
                string filePath = @"d:\test";

                // Check if the file exists
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File does not exist.");
                    return;
                }

                // Read all text from the file
                string content = File.ReadAllText(filePath);

                // Split the content into words
                string[] words = content.Split(new[] { ' ', '\n', '\r', '\t', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

                // Find the longest word
                string longestWord = words.OrderByDescending(word => word.Length).FirstOrDefault();

                // Display the result
                if (!string.IsNullOrEmpty(longestWord))
                {
                    Console.WriteLine($"The longest word is: {longestWord}");
                }
                else
                {
                    Console.WriteLine("No words found in the file.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}