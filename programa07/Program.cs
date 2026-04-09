// __________________________ EJERCICIO N1___________________//
namespace Programa08;

class Program
{
    static void Main(string[] args)
    {
        const decimal IVA = 0.21m;
        const bool SISTEMA_ACTIVO = true;
        const char MONEDA = '$';

        Console.WriteLine("--- SUPERMERCADO ---");
        Console.WriteLine("Sistema activo: " + SISTEMA_ACTIVO);

        decimal precioProducto = 2300.75m;
        decimal ivaCalculado = precioProducto * IVA;
        decimal total = precioProducto + ivaCalculado;

        Console.WriteLine("\nPrecio: " + MONEDA + precioProducto);
        Console.WriteLine("IVA: " + MONEDA + ivaCalculado);
        Console.WriteLine("TOTAL: " + MONEDA + total);

        Console.ReadLine();
    }
}
// __________________________ EJERCICIO N2___________________//
namespace Programa09;

class Program
{
    static void Main(string[] args)
    {
        const decimal IVA = 0.21m;
        const bool DESCUENTO_ACTIVO = false;
        const char SIMBOLO = '$';

        Console.WriteLine("--- TIENDA DE ROPA ---");
        Console.WriteLine("Descuento activo: " + DESCUENTO_ACTIVO);

        decimal precio = 5000m;
        decimal impuesto = precio * IVA;
        decimal total = precio + impuesto;

        Console.WriteLine("\nPrecio base: " + SIMBOLO + precio);
        Console.WriteLine("IVA: " + SIMBOLO + impuesto);
        Console.WriteLine("Total a pagar: " + SIMBOLO + total);

        Console.ReadLine();
    }
}
// __________________________ EJERCICIO N3___________________//
namespace Programa10;

class Program
{
    static void Main(string[] args)
    {
        const decimal IVA = 0.21m;
        const bool MODO_DEBUG = true;
        const char MONEDA = '$';

        Console.WriteLine("--- TIENDA TECNO ---");
        Console.WriteLine("Modo debug: " + MODO_DEBUG);

        decimal precioLaptop = 120000m;
        decimal iva = precioLaptop * IVA;
        decimal total = precioLaptop + iva;

        Console.WriteLine("\nPrecio: " + MONEDA + precioLaptop);
        Console.WriteLine("IVA: " + MONEDA + iva);
        Console.WriteLine("TOTAL: " + MONEDA + total);

        Console.ReadLine();
    }
}
// __________________________ EJERCICIO N4___________________//
namespace Programa11;

class Program
{
    static void Main(string[] args)
    {
        const decimal IVA = 0.21m;
        const bool SERVICIO_ACTIVO = true;
        const char MONEDA = '$';

        Console.WriteLine("--- SUSCRIPCIÓN ONLINE ---");
        Console.WriteLine("Servicio activo: " + SERVICIO_ACTIVO);

        decimal precioMensual = 3500m;
        decimal impuesto = precioMensual * IVA;
        decimal total = precioMensual + impuesto;

        Console.WriteLine("\nPrecio mensual: " + MONEDA + precioMensual);
        Console.WriteLine("IVA: " + MONEDA + impuesto);
        Console.WriteLine("Total: " + MONEDA + total);

        Console.ReadLine();
    }
}
// __________________________ EJERCICIO N5___________________//
namespace Programa12;

class Program
{
    static void Main(string[] args)
    {
        const decimal IVA = 0.21m;
        const bool SERVICIO_INCLUIDO = true;
        const char MONEDA = '$';

        Console.WriteLine("--- RESTAURANTE ---");
        Console.WriteLine("Servicio incluido: " + SERVICIO_INCLUIDO);

        decimal consumo = 8900.30m;
        decimal iva = consumo * IVA;
        decimal total = consumo + iva;

        Console.WriteLine("\nConsumo: " + MONEDA + consumo);
        Console.WriteLine("IVA: " + MONEDA + iva);
        Console.WriteLine("TOTAL A PAGAR: " + MONEDA + total);

        Console.ReadLine();
    }
}
