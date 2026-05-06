using System;

class Program
{
    static void Main()
    {
        int num, i, fact;

        Console.Write("Ingrese un número: ");
        num = Convert.ToInt32(Console.ReadLine());

        i = num;
        fact = 1;

        do
        {
            fact = fact * i;
            i = i - 1;

        } while (i != 0);

        Console.WriteLine("El factorial es: " + fact);
    }
}