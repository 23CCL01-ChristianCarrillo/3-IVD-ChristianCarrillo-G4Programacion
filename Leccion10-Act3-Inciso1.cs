using System;

class Program
{
    static void Main()
    {
        int i, j, cont, suma;

        suma = 0;

        for (i = 2; i <= 22; i++)
        {
            cont = 0;

            for (j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    cont = cont + 1;
                }
            }

            if (cont == 2)
            {
                suma = suma + i;
            }
        }

        Console.WriteLine("La suma de los números primos entre 1 y 22 es: " + suma);
    }
}