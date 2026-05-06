using System;

class Cajero
{
    static void Main()
    {
        int i, dinero;
        int cont = 0;
        int suma = 0;

        Random rand = new Random();

        for (i = 1; i <= 1000; i++)
        {
            int opcion = rand.Next(1, 4); // 1, 2 o 3

            switch (opcion)
            {
                case 1:
                    dinero = 20;
                    break;
                case 2:
                    dinero = 50;
                    break;
                default:
                    dinero = 100;
                    break;
            }

            if (dinero == 100)
            {
                cont++;
                suma += 100;
            }
        }

        Console.WriteLine("Cantidad de billetes de 100: " + cont);
        Console.WriteLine("Total de dinero con billetes de $100: $" + suma);
    }
}