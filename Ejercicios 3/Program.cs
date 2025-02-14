using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        string nombreCliente;
        char tipoMembresia;
        double totalCompra, descuento = 0, totalPagar;

        Console.WriteLine("Bienvenido a la Panadería");

        Console.Write("Nombre del cliente: ");
        nombreCliente = Console.ReadLine();

        Console.Write("Total de la compra: L ");
        while (!double.TryParse(Console.ReadLine(), out totalCompra) || totalCompra < 0)
        {
            Console.Write("Por favor, ingrese un valor válido para el total de la compra: L ");
        }

        Console.Write("Tipo de membresía (A, B o C): ");
        tipoMembresia = char.ToUpper(Console.ReadLine()[0]);

        switch (tipoMembresia)
        {
            case 'A':
                descuento = totalCompra * 0.10;
                break;
            case 'B':
                descuento = totalCompra * 0.15;
                break;
            case 'C':
                descuento = totalCompra * 0.20;
                break;
            default:
                Console.WriteLine("Tipo de membresía no válido. No se aplicará descuento.");
                break;
        }

        totalPagar = totalCompra - descuento;

        Console.WriteLine("\n Factura ");
        Console.WriteLine($"Cliente: {nombreCliente}");
        Console.WriteLine($"Total de la compra: L {totalCompra:F2}");
        Console.WriteLine($"Tipo de membresía: {tipoMembresia}");
        Console.WriteLine($"Descuento aplicado: L {descuento:F2}");
        Console.WriteLine($"Total a pagar: ${totalPagar:F2}");
    }
}
