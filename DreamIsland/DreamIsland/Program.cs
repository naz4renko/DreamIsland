using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using DreamIsland.Logic;
using DreamIsland.DataAccess;
using DreamIsland.UserInterface;
internal class Program
{
    private static void Main(string[] args)
    {
        if (!Verification.IsArgsEmpty(args))
        {
            ConsolePrint.FilesNotFound();
            Environment.Exit(0);
        }
        if (!Verification.IsPathExists(args[0]))
        {
            ConsolePrint.FilesNotFound();
            Environment.Exit(0);
        }

        ConsolePrint.HelloUser();

        WorkWithFile work = new WorkWithFile();
        Park myPark;
        myPark = work.InitializationPark(args[0], args[1]);

        MainController main = new MainController();
        Client client = main.CreateClient(myPark);
        main.MainProcess(myPark, client);

        Order order1 = new Order(client);
        work.SaveCheckInFile(order1, args[2]);

        Console.ReadKey();
    }
}