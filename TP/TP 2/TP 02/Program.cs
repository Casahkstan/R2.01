// See https://aka.ms/new-console-template for more information

using TP_02;

namespace R2._01.TP.TP_2.TP_02;

partial class Program
{
    public static int Main()
    {
        Test2();
        return 0;
    }

    private static void Test1()
    {
        Printer printer = new Printer();
        printer.LoadSheet(100);
        printer.Print(10);
        Console.WriteLine(printer.GetMoney());
        printer.Print(15);
        Console.WriteLine(printer.GetMoney());
        printer.Print(40);
        Console.WriteLine(printer.GetMoney());
        printer.TakeMoney();
        Console.WriteLine(printer.GetMoney());
        printer.Print(40);
        Console.WriteLine(printer.IsEmpty());
        Console.WriteLine(printer.GetMoney());
    }

    private static void Test2()
    {
        Printer salleProf = new Printer();
        Printer bilbiotheque = new Printer();
        salleProf.LoadSheet(1000);
        bilbiotheque.LoadSheet(1000);
        salleProf.Print(200);
        bilbiotheque.Print(12);
        salleProf.Print(500);
        bilbiotheque.Print(30);
        salleProf.Print(400);
        bilbiotheque.Print(3);

        Console.WriteLine(salleProf.GetMoney());
        Console.WriteLine(bilbiotheque.GetMoney());
    }
}