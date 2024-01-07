using OperatingSystem;

namespace FactoryPattern;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the Operating System manufacturer's name");
        string manufacturer = Console.ReadLine()!;
        IOperatingSystem? os = OperatingSystemFactory.GetOperatingSystemByManufacturer(manufacturer);
        string details;
        if (os == null)
            details = "We do not have any operating system from this manufacturer in our accout";
        else
            details = os.PrintDetails();
        Console.WriteLine(details);
    }
}