using ServiceIntegrationMain.Assets;

namespace ServiceIntegrationMain;

public class Program
{
    private static int Main(string[] args)
    {
        Console.WriteLine(Greeting.Welcome);
        Console.WriteLine(Greeting.Askforchoice);
        Console.WriteLine("\x1b[32mThis text is green\x1b[0m");

        return 1;
    }
}