using System;

class Program
{
    static void Main()
    {
        int num, i, result;

        Console.Write("Ingrese un número: ");
        num = Convert.ToInt32(Console.ReadLine());

        i = 1;

        while (i <= 10)
        {
            result = num * i;
            Console.WriteLine(num + " x " + i + " = " + result);
            i = i + 1;
        }
    }
}