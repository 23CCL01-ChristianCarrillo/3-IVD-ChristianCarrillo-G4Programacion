using System;

class PrimosyPares
{
    static void Main()
    {
        int i, j;
        bool esPrimo;
        int cont = 0;
        int suma = 0;

        i = 300;

        while (i >= 1)
        {
            // Sumar pares
            if (i % 2 == 0)
            {
                suma += i;
            }

            // Verificar primo
            esPrimo = true;

            if (i <= 1)
            {
                esPrimo = false;
            }
            else
            {
                j = 2;
                while (j < i && esPrimo)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                    }
                    j++;
                }
            }

            if (esPrimo)
            {
                cont++;
            }

            i--;
        }

        Console.WriteLine("Cantidad de los numeros primos: " + cont);
        Console.WriteLine("Suma de los numeros pares: " + suma);
    }
}