using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Ingrese el salario del empleado: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        
        double aumento = CalcularAumento(salario);

        
        double salarioFinal = salario + aumento;

        
        Console.WriteLine($"El aumento es: ${aumento:F2}");
        Console.WriteLine($"El salario final es: ${salarioFinal:F2}");
    }

    
    static double CalcularAumento(double salario)
    {
        double aumento = 0;

        if (salario >= 0 && salario <= 4999)
        {
            aumento = salario * 0.20; 
        }
        else if (salario >= 5000 && salario <= 9999)
        {
            aumento = salario * 0.10; 
        }
        else if (salario >= 10000 && salario <= 14999)
        {
            aumento = salario * 0.05; 
        }
        else if (salario >= 15000)
        {
            aumento = salario * 0.03; 
        }

        return aumento;
    }
}
