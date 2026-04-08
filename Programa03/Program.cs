using System;

class Program
{
    static void Main(string[] args)
    {
        double pesocebolla = 4.75;
        Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
        Console.WriteLine("Valor guardado: " + pesocebolla + " kilos");

        decimal precioProducto = 839.99m;
        Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
        Console.WriteLine("¡Obligatorio para dinero! Usa la 'm'.");
        Console.WriteLine("Valor guardado: $" + precioProducto);
    }
}
