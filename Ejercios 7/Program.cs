using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.Write("Ingrese un carácter: ");
                char caracter = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine(); // Salto de línea

                switch (caracter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine("Es una Vocal.");
                        break;
                    default:
                        Console.WriteLine("No es Vocal.");
                        break;
                }
            }
        }
    }
}
