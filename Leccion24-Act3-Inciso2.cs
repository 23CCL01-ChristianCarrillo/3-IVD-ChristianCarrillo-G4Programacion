using System;

class CuentaRegresiva
{
    static void Main()
    {
        int num, i, suma;

        Console.WriteLine("Ingrese un numero: ");
        num = int.Parse(Console.ReadLine());

        suma = 0;

        for (i = num; i >= 1; i--)
        {
            Console.WriteLine(i);
            suma += i;
        }

        Console.WriteLine("La suma de los numeros es: " + suma);
    }
}