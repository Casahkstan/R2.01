using Exo3;

namespace R2._01.TP.TP_3.Exo3.Exo3
{
    class Program
    {
        static void Exo_3(string[] args)
        {
            Fraction f1 = new Fraction(5, 3);
            Fraction f2 = new Fraction(2, 7);

            Fraction f3 = Fraction.Add(f1, f2);
            Console.WriteLine("{0} = {1}", f3, f3.Value);
        }
    }
}