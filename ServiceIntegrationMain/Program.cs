using ServiceIntegrationMain.Assets;

namespace ServiceIntegrationMain;

internal class Program
{
    private static int Main(string[] args)
    {
        Console.WriteLine(Greeting.Welcome);
        Console.WriteLine(Greeting.Askforchoice);
        
        return 1;
    }
}