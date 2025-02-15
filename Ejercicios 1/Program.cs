using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int precioCamisa = 100;
        Console.Write("¿Cuántas camisas quieres comprar? ");
        int cantidadCamisas = int.Parse(Console.ReadLine());
        double totalSinDescuento = cantidadCamisas * precioCamisa;
        double descuento = 0;

        if (cantidadCamisas > 30) 
        {
            descuento = totalSinDescuento * 0.40; 
        }
        else if (cantidadCamisas > 20) 
        {
            descuento = totalSinDescuento * 0.20; 
        }
        else if (cantidadCamisas > 10) 
        {
            descuento = totalSinDescuento * 0.10; 
        }
        
        double totalPagar = totalSinDescuento - descuento;

        Console.WriteLine("\nResumen de tu compra");
        Console.WriteLine("Camisas compradas: " + cantidadCamisas);
        Console.WriteLine("Precio por camisa: $" + precioCamisa);
        Console.WriteLine("Total sin descuento: $" + totalSinDescuento);
        Console.WriteLine("Descuento aplicado: $" + descuento);
        Console.WriteLine("Total a pagar: $" + totalPagar);
    }
}
