using System;

class Program
{
    static void Main()
    {
        
        double totalRecibos = 0;

        
        Console.WriteLine("Cliente | Horas Estacionado | Cargo");
        Console.WriteLine("------------------------------------");

        
        for (int i = 1; i <= 3; i++)
        {
            
            Console.Write($"Ingrese las horas estacionado para el cliente {i}: ");
            double horas = Convert.ToDouble(Console.ReadLine());

            
            double cargo = CalcularCargos(horas);

           
            Console.WriteLine($"Cliente {i} | {horas} horas | ${cargo}");

            
            totalRecibos += cargo;
        }

        
        Console.WriteLine("\nTotal de los recibos de ayer: $" + totalRecibos);
    }

    
    static double CalcularCargos(double horas)
    {
        double cargo = 2.00; 

        if (horas > 3)
        {
            double horasExtras = horas - 3;
            cargo += horasExtras * 0.50; 

            if (cargo > 10.00)
            {
                cargo = 10.00; 
            }
        }

        return cargo;
    }
}
