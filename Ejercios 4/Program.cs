using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        


            {
                Console.Write("Ingrese el número de empleados: ");
                if (!int.TryParse(Console.ReadLine(), out int numEmpleados) || numEmpleados <= 0)
                {
                    Console.WriteLine("Número inválido. Intente nuevamente.");
                    return;
                }

                int contador = 0;

                while (contador < numEmpleados)
                {
                    Console.WriteLine($"\nEmpleado {contador + 1}:");

                    Console.Write("Ingrese el nombre del empleado: ");
                    string nombre = Console.ReadLine();

                    double horasTrabajadas;
                    Console.Write("Ingrese las horas trabajadas: ");
                    while (!double.TryParse(Console.ReadLine(), out horasTrabajadas) || horasTrabajadas < 0)
                    {
                        Console.Write("Por favor, ingrese un número válido de horas: ");
                    }

                    double tarifaPorHora;
                    Console.Write("Ingrese la tarifa por hora: ");
                    while (!double.TryParse(Console.ReadLine(), out tarifaPorHora) || tarifaPorHora <= 0)
                    {
                        Console.Write("Por favor, ingrese una tarifa válida: ");
                    }

                    double sueldoBruto = (horasTrabajadas > 40)
                        ? (40 * tarifaPorHora) + ((horasTrabajadas - 40) * (tarifaPorHora * 1.5))
                        : horasTrabajadas * tarifaPorHora;

                    Console.WriteLine($"El sueldo bruto de {nombre} es: {sueldoBruto:C}");

                    contador++;
                }

                Console.WriteLine("\nCálculo de sueldos completado.");

            }
        }
    }

