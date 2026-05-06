using System;

class Program
{
    static void Main()
    {
        int carros, disp;

        carros = 0;

        do
        {
            disp = 200 - carros;

            Console.WriteLine("Espacios disponibles: " + disp);

            carros = carros + 1;

        } while (carros < 200);

        Console.WriteLine("Ya no hay espacios libres");
    }
}