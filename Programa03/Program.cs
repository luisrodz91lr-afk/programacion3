//EJERCICIO N1 PESO PRECIO//
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
// EJERCICIO N2 ALTURA PRECIO //
using System;

class Program
{
    static void Main(string[] args)
    {
        double alturaPersona = 1.68;
        Console.WriteLine("TIPO DOUBLE:");
        Console.WriteLine("Valor guardado: " + alturaPersona + " metros");

        decimal precioZapato = 12500.50m;
        Console.WriteLine("\nTIPO DECIMAL:");
        Console.WriteLine("Valor guardado: $" + precioZapato);
    }
}
//EJERCICIO N3 TEMPERATURA COSTO//
using System;

class Program
{
    static void Main(string[] args)
    {
        double temperatura = 36.6;
        Console.WriteLine("TIPO DOUBLE:");
        Console.WriteLine("Temperatura corporal: " + temperatura + " °C");

        decimal costoConsulta = 3500.75m;
        Console.WriteLine("\nTIPO DECIMAL:");
        Console.WriteLine("Costo de consulta: $" + costoConsulta);
    }
}
//EJERCICIO N4 DISTANCIA PRECIO //
using System;

class Program
{
    static void Main(string[] args)
    {
        double distancia = 152.8;
        Console.WriteLine("TIPO DOUBLE:");
        Console.WriteLine("Distancia recorrida: " + distancia + " km");

        decimal precioNafta = 980.99m;
        Console.WriteLine("\nTIPO DECIMAL:");
        Console.WriteLine("Precio por litro: $" + precioNafta);
    }
}
//EJERCICIO N5 PESO TOTAL DE COMPRA//
using System;

class Program
{
    static void Main(string[] args)
    {
        double pesoFruta = 2.35;
        Console.WriteLine("TIPO DOUBLE:");
        Console.WriteLine("Peso de fruta: " + pesoFruta + " kg");

        decimal totalCompra = 4599.90m;
        Console.WriteLine("\nTIPO DECIMAL:");
        Console.WriteLine("Total a pagar: $" + totalCompra);
    }
}