namespace CSharpFundamentals.Files;

public class Paths
{
    public static void PathProgram()
    {
        var path = @"D:\Repositories\CSharpFundamentals\CSharpFundamentals.sln";

        var dotIndex = path.IndexOf('.');
        var extension = path.Substring(dotIndex);

        Console.WriteLine("Extension: " + Path.GetExtension(path));
        Console.WriteLine("File Name: " + Path.GetFileName(path));
        Console.WriteLine("File Name: without Extension: "  + Path.GetFileNameWithoutExtension(path));
        Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
    }
}
