using System;

class Program
{
    static void Main()
    {
        int corte;

        for (corte = 1; corte <= 8; corte++)
        {
            Console.WriteLine("Sello " + corte + " agregado a la cuponera");
        }

        Console.WriteLine("Has logrado completar los 8 sellos");
        Console.WriteLine("Obtuviste un corte gratis");
    }
}