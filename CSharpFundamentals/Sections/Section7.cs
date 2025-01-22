namespace CSharpFundamentals.Sections;

/// <summary>
/// Working with Files
/// </summary>
public static class Section7
{
    public static void Run()
    {
        FileAndFileInfo();
        DirectoryAndDirectoryInfo();
        Paths();
    }

    private static void FileAndFileInfo()
    {
        Console.WriteLine("Start -> File and FileInfo");

        var path = @"d:\somefile.jpg";

        File.Copy(@"d:\temp\myfile.jpg", @"d:\temp1\myfile.jpg", true);
        File.Delete(path);

        if (File.Exists(path))
        {
            //
        }
        var content = File.ReadAllText(path);

        var fileInfo = new FileInfo(content);
        fileInfo.CopyTo("...");
        fileInfo.Delete();
        if (fileInfo.Exists)
        {
            //
        }

        Console.WriteLine("Finish -> File And FileInfo");
    }

    private static void DirectoryAndDirectoryInfo()
    {
        Console.WriteLine("Start -> Directory and DirectoryInfo");

        Directory.CreateDirectory(@"d:\temp\folder1");

        var files = Directory.GetFiles(@"D:\Repositories\CSharpFundamentals", "*.sln", SearchOption.AllDirectories);

        foreach (var file in files)
            Console.WriteLine(file);

        var directories = Directory.GetDirectories(@"D:\Repositories\CSharpFundamentals", "*.*", SearchOption.AllDirectories);

        foreach (var directory in directories)
            Console.WriteLine(directory);

        Directory.Exists("...");

        var directoryInfo = new DirectoryInfo("...");
        directoryInfo.GetFiles();
        directoryInfo.GetDirectories();

        Console.WriteLine("Finish -> Directory and DirectoryInfo");
    }

    private static void Paths()
    {
        var path = @"D:\Repositories\CSharpFundamentals\CSharpFundamentals.sln";

        var dotIndex = path.IndexOf('.');
        var extension = path.Substring(dotIndex);

        Console.WriteLine("Extension: " + Path.GetExtension(path));
        Console.WriteLine("File Name: " + Path.GetFileName(path));
        Console.WriteLine("File Name: without Extension: " + Path.GetFileNameWithoutExtension(path));
        Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
    }

    public static void Exercises()
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
