using System;

class RuedaDeLaFortuna
{
    static void Main()
    {
        int opcion;
        int boletos = 0;
        int total = 0;

        opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine("Ingrese tipo de entrada (1=niño, 2=adulto, 0=salir): ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                total += 10;
                boletos++;
            }
            else if (opcion == 2)
            {
                total += 15;
                boletos++;
            }
        }

        Console.WriteLine("Boletos vendidos: " + boletos);
        Console.WriteLine("Total recaudado: $" + total);
    }
}