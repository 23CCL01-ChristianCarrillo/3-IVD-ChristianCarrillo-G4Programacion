using System;

class Program
{
    static void Main()
    {
        int final, num;

        Console.Write("Ingrese un número: ");
        final = Convert.ToInt32(Console.ReadLine());

        num = 20;

        while (num <= final)
        {
            if (num % 2 != 0)
            {
                Console.WriteLine(num);
            }

            num = num + 1;
        }
    }
}