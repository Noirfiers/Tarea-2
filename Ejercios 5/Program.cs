using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
        {
            {
                Console.Write("Ingrese un número positivo: ");
                int numero;

                if (int.TryParse(Console.ReadLine(), out numero) && numero > 0)
                {
                    if (numero < 10)
                        Console.WriteLine("Tiene 1 cifra.");
                    else if (numero < 100)
                        Console.WriteLine("Tiene 2 cifras.");
                    else if (numero < 1000)
                        Console.WriteLine("Tiene 3 cifras.");
                    else if (numero < 10000)
                        Console.WriteLine("Tiene 4 cifras.");
                    else
                        Console.WriteLine("Mayor a 5 cifras.");
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido y positivo.");
                }
            }
        }
    }
    }
}
