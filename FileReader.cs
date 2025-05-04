using System;
using System.IO;

class FileReadExample
{
    static void Main()
    {
        string filePath = "Sample.txt";
        try
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);

                Console.WriteLine("File Contents:");
                Console.WriteLine("-------------------------");
                Console.WriteLine(content);
                Console.WriteLine("-------------------------");
                Console.WriteLine($"File Size: {new FileInfo(filePath).Length} bytes");
            }
            else
            {
                Console.WriteLine($"File not found: {filePath}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while reading the file.");
            Console.WriteLine($"Error: {ex.Message}");
        }
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
