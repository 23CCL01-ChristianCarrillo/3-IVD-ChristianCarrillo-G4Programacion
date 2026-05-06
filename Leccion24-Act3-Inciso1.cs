using System;

class SumaDePrimos
{
    static void Main()
    {
        int i, j;
        bool esPrimo;
        int suma = 0;

        for (i = 2; i <= 50; i++)
        {
            esPrimo = true;
            j = 2;

            while (j * j <= i && esPrimo)
            {
                if (i % j == 0)
                {
                    esPrimo = false;
                }
                j++;
            }

            if (esPrimo)
            {
                suma += i;
            }
        }

        Console.WriteLine("Suma de los numeros primos: " + suma);
    }
}