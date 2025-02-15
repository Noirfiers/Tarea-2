using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double totalVenta = 0;
                int producto, cantidad;

                Console.WriteLine("Ingrese el número del producto (1-5) y la cantidad vendida.");
                Console.WriteLine("Ingrese 0 como número de producto para finalizar.");

                while (true)
                {
                    Console.Write("\nNúmero del producto: ");
                    if (!int.TryParse(Console.ReadLine(), out producto) || producto < 0 || producto > 5)
                    {
                        Console.WriteLine("Número de producto inválido. Intente de nuevo.");
                        continue;
                    }

                    if (producto == 0) // Centinela para salir del bucle
                        break;

                    Console.Write("Cantidad vendida: ");
                    if (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad < 0)
                    {
                        Console.WriteLine("Cantidad inválida. Intente de nuevo.");
                        continue;
                    }

                    double precio = 0;

                    switch (producto)
                    {
                        case 1: precio = 2.98; break;
                        case 2: precio = 4.50; break;
                        case 3: precio = 9.98; break;
                        case 4: precio = 4.49; break;
                        case 5: precio = 6.87; break;
                    }

                    double subtotal = precio * cantidad;
                    totalVenta += subtotal;

                    Console.WriteLine($"Subtotal por este producto: ${subtotal:F2}");
                }

                Console.WriteLine($"\nTotal de ventas: ${totalVenta:F2}");
            }
        }
    }
}
