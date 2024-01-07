using OperatingSystem;

namespace FactoryPattern;

public class OperatingSystemFactory
{
    public static IOperatingSystem? GetOperatingSystemByManufacturer(string manufacturer)
    {
        return manufacturer.ToLower() switch
        {
            "google" => new Android(),
            "microsoft" => new Windows(),
            "apple" => new MacOS(),
            "oracle" => new Solaris(),
            _ => null
        };
    }
}
