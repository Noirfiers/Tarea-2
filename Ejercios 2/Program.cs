using System;

class Application
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n--- Ingrese los datos del cliente ---");

            int numeroCuenta = ReadInt("Número de cuenta: ");
            double saldoInicial = ReadDouble("Saldo al inicio del mes: ");
            double cargos = ReadDouble("Total de artículos cargados en el mes: ");
            double creditos = ReadDouble("Total de créditos aplicados en el mes: ");
            double limiteCredito = ReadDouble("Límite de crédito permitido: ");

            double nuevoSaldo = saldoInicial + cargos - creditos;

            if (nuevoSaldo > limiteCredito)
            {
                Console.WriteLine("\n¡Alerta! El cliente ha excedido el límite de crédito.");
                Console.WriteLine($"Número de cuenta: {numeroCuenta}");
                Console.WriteLine($"Límite de crédito: {limiteCredito:C}");
                Console.WriteLine($"Nuevo saldo: {nuevoSaldo:C}");
                Console.WriteLine("Mensaje: Se excedió el límite de su crédito.");
            }
            else
            {
                Console.WriteLine("\nEl cliente no ha excedido el límite de crédito.");
                Console.WriteLine($"Número de cuenta: {numeroCuenta}");
                Console.WriteLine($"Nuevo saldo: {nuevoSaldo:C}");
            }
        }
    }
    static int ReadInt(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }

    static double ReadDouble(string prompt)
    {
        Console.Write(prompt);
        return double.Parse(Console.ReadLine());
    }
}
