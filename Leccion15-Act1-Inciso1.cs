using System;

class Program
{
    static void Main()
    {
        int tipo, totalboletos, totaldinero;

        totalboletos = 0;
        totaldinero = 0;

        do
        {
            Console.WriteLine("Ingrese tipo de boleto (1=Adulto $15, 2=Niño $10, 0=Salir):");
            tipo = Convert.ToInt32(Console.ReadLine());

            if (tipo == 1)
            {
                totalboletos = totalboletos + 1;
                totaldinero = totaldinero + 15;
            }

            if (tipo == 2)
            {
                totalboletos = totalboletos + 1;
                totaldinero = totaldinero + 10;
            }

        } while (tipo != 0);

        Console.WriteLine("Total boletos vendidos: " + totalboletos);
        Console.WriteLine("Total dinero recaudado: $" + totaldinero);
    }
}