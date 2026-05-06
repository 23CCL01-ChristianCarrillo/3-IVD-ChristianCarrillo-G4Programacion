using System;

class Multiplos
{
    static void Main()
    {
        int num, i, multi;

        Console.WriteLine("Ingrese un numero: ");
        num = int.Parse(Console.ReadLine());

        for (i = 1; i <= 20; i++)
        {
            multi = num * i;
            Console.WriteLine(num + " x " + i + " = " + multi);
        }
    }
}