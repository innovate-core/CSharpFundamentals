namespace CSharpFundamentals.Files;

public class DirectoryAndDirectoryInfo
{
    public static void DirectoryAndDirectoryInfoProgram()
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
}
