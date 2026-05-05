using System;

class Program
{
    static void Main()
    {
        double pesofinal = 0;
        double manzana;

        while (pesofinal < 1000)
        {
            Console.Write("Coloca una manzana en la báscula (en gramos): ");
            manzana = Convert.ToDouble(Console.ReadLine());

            pesofinal = pesofinal + manzana;

            Console.WriteLine("Peso acumulado: " + pesofinal + " g");
        }

        Console.WriteLine("Ya tienes 1 kg de manzanas");
    }
}