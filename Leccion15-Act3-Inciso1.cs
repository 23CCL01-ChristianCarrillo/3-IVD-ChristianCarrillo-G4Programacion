using System;

class MultiplosDe7
{
    static void Main()
    {
        int i, mult;
        int suma = 0;
        int cont = 0;

        for (i = 1; i <= 20; i++)
        {
            mult = i * 7;

            suma += mult;

            if (mult % 2 == 0)
            {
                cont++;
            }
        }

        Console.WriteLine("La sumatoria de los primeros 20 multiplos de 7: " + suma);
        Console.WriteLine("La cantidad de multiplos pares es: " + cont);
    }
}