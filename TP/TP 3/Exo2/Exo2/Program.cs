using Exo2;

namespace R2._01.TP.TP_3.Exo2.Exo2
{
    class Program
    {
        static void Exo_2(string[] args)
        {
            // Test de l'heure
            Time t1 = new Time(0);
            Time t2 = new Time(15, 24, 40);

            t1.Add(4000); // 4000s = 1heure 6 minutes 40 secondes
            t2.Add(30);
            Console.WriteLine(t1.ToString()); // 01:06:40
            Console.WriteLine(t2.ToString()); // 15:25:10
            Console.WriteLine(t1.Hours); // 1
            Console.WriteLine(t2.Minutes); // 25
        }
    }
}