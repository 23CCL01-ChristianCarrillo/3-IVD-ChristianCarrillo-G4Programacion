using System;

class Program
{
    static void Main()
    {
        int num, suma;

        suma = 0;

        do
        {
            Console.Write("Ingrese un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num != 9)
            {
                suma = suma + num;
            }

        } while (num != 9);

        Console.WriteLine("La suma total es: " + suma);
    }
}