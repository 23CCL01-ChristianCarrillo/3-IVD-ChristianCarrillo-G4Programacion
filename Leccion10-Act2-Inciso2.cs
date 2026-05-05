using System;

class Program
{
    static void Main()
    {
        int final, i;

        Console.Write("Ingrese un número: ");
        final = Convert.ToInt32(Console.ReadLine());

        for (i = 2; i <= final; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}