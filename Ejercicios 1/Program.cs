using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Precio de cada camisa
        int precioCamisa = 100;

        // Pedir al usuario cuántas camisas quiere comprar
        Console.Write("¿Cuántas camisas quieres comprar? ");
        int cantidadCamisas = int.Parse(Console.ReadLine());

        // Calcular el total sin descuento
        double totalSinDescuento = cantidadCamisas * precioCamisa;

        // Calcular el descuento según la cantidad de camisas
        double descuento = 0;

        if (cantidadCamisas > 30) // Si compra más de 30 camisas
        {
            descuento = totalSinDescuento * 0.40; // 40% de descuento
        }
        else if (cantidadCamisas > 20) // Si compra más de 20 camisas
        {
            descuento = totalSinDescuento * 0.20; // 20% de descuento
        }
        else if (cantidadCamisas > 10) // Si compra más de 10 camisas
        {
            descuento = totalSinDescuento * 0.10; // 10% de descuento
        }

        // Calcular el total a pagar con el descuento
        double totalPagar = totalSinDescuento - descuento;

        // Mostrar los resultados
        Console.WriteLine("\n--- Resumen de tu compra ---");
        Console.WriteLine("Camisas compradas: " + cantidadCamisas);
        Console.WriteLine("Precio por camisa: $" + precioCamisa);
        Console.WriteLine("Total sin descuento: $" + totalSinDescuento);
        Console.WriteLine("Descuento aplicado: $" + descuento);
        Console.WriteLine("Total a pagar: $" + totalPagar);
    }
}
