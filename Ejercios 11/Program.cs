
using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Ingrese la primera nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la tercera nota: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        
        double promedio = (nota1 + nota2 + nota3) / 3;

        
        Console.WriteLine($"El promedio es: {promedio:F2}");

        
        string resultado = ObtenerResultado(promedio);
        Console.WriteLine($"El resultado es: {resultado}");
    }

    
    static string ObtenerResultado(double promedio)
    {
        
        switch (promedio)
        {
            case double n when (n < 70):
                return "Reprueba";

            case double n when (n <= 80):
                return "Bueno";

            case double n when (n <= 90):
                return "Muy Bueno";

            case double n when (n <= 100):
                return "Sobresaliente";

            default:
                return "Error";
        }
    }
}
