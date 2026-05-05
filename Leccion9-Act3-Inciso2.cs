using System;

class Program
{
    static void Main()
    {
        int num, i, cont;

        Console.Write("Ingrese un número: ");
        num = Convert.ToInt32(Console.ReadLine());

        i = 1;
        cont = 0;

        while (i <= num)
        {
            if (num % i == 0)
            {
                cont = cont + 1;
            }

            i = i + 1;
        }

        if (cont == 2)
        {
            Console.WriteLine("El número es primo");
        }
        else
        {
            Console.WriteLine("El número no es primo");
        }
    }
}