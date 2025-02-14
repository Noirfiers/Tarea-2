using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroAdivinar = random.Next(1, 1001);
        int intento;
        bool adivinar = false;

        Console.WriteLine("¡Bienvenido al juego 'Adivina el número'!");
        Console.WriteLine("Un número entre 1 y 1000.");

        while (!adivinar)
        {
            Console.Write("Introduce tu intento: ");
            try
            {
                intento = int.Parse(Console.ReadLine());

                if (intento < numeroAdivinar)
                {
                    Console.WriteLine("Demasiado bajo. Prueba denuevo");
                }
                else if (intento > numeroAdivinar)
                {
                    Console.WriteLine("Demasiado alto. Prueba denuevo");
                }
                else
                {
                    Console.WriteLine("Eres el ganador de la loto");
                    adivinar = true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada no válida. Por favor, introduce un número entero.");
            }
        }
    }
}
