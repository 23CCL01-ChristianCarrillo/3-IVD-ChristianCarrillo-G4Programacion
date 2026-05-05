using System;

class Program
{
    static void Main()
    {
        int monedas = 0;
        int totales;

        while (monedas < 350)
        {
            Console.WriteLine("Tienes " + monedas + " monedas. Consigue 350 para desbloquear el nivel 5.");
            Console.Write("¿Cuántas monedas conseguiste? ");
            totales = Convert.ToInt32(Console.ReadLine());

            monedas = monedas + totales;
        }

        Console.WriteLine("Nivel 5 desbloqueado");
    }
}