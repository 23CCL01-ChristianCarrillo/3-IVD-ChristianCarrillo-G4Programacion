using System;

class Tablas
{
    static void Main()
    {
        int num, i, result;

        Console.WriteLine("Ingrese un numero: ");
        num = int.Parse(Console.ReadLine());

        i = 1;

        while (i <= 10)
        {
            result = num * i;
            Console.WriteLine(num + " x " + i + " = " + result);
            i++;
        }
    }
}