using System;

class PrimosOptimizado
{
    static void Main()
    {
        int cont = 0;
        int sum = 0;

        for (int i = 2; i <= 100; i++)
        {
            bool esPrimo = true;

            for (int u = 2; u * u <= i; u++)
            {
                if (i % u == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if (esPrimo)
            {
                cont++;
                sum += i;
            }
        }

        Console.WriteLine("Cantidad de numeros primos: " + cont);
        Console.WriteLine("Suma de los numeros primos: " + sum);
    }
}