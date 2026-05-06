using System;

class Program
{
    static void Main()
    {
        int num1, num2, menor, mayor, suma;

        Console.Write("Ingrese el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 < num2)
        {
            menor = num1;
            mayor = num2;
        }
        else
        {
            menor = num2;
            mayor = num1;
        }

        suma = 0;

        do
        {
            suma = suma + menor;
            menor = menor + 1;

        } while (menor <= mayor);

        Console.WriteLine("La suma de los números entre ellos es: " + suma);
    }
}