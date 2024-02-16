using exo1;

namespace R2._01.TP.TP_3.Exo_1.TP03;

class Program
{
    public static int Exo_1()
    {
        Product.VAT = 0.2f;
        Product sp01 = new Product("SP01", "Smarphone FaitIUT 0121", 250);
        Console.WriteLine("Nom: " + sp01.Name + ", Prix: " + sp01.PriceET);
        sp01.PriceET = 200;
        sp01.Name = "Smartphone FaitIUT 0121";
        Console.WriteLine("Nom: " + sp01.Name + ", Prix: " + sp01.PriceET);
        return 0;
    }
}