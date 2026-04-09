// ------------------------EJERCICIO N1--------------------------- //
namespace 06;

class Program
{
    static void Main(string[] args)
    {
        const string NOMBRE_CINE = "CineMax";
        const int EDAD_MINIMA = 16;

        Console.WriteLine("=== " + NOMBRE_CINE + " ===");

        const int EDAD_CLIENTE = 15;
        const bool PUEDE_ENTRAR = EDAD_CLIENTE >= EDAD_MINIMA;

        Console.WriteLine("Cliente de " + EDAD_CLIENTE + " años");
        Console.WriteLine("¿Puede entrar?: " + PUEDE_ENTRAR);

        Console.ReadLine();
    }
}
// ------------------------EJERCICIO N2--------------------------- //
namespace Programa06;

class Program
{
    static void Main(string[] args)
    {
        const string NOMBRE_LUGAR = "Disco Night";
        const int EDAD_MINIMA = 21;

        Console.WriteLine("=== " + NOMBRE_LUGAR + " ===");

        const int EDAD_PERSONA = 25;
        const bool ACCESO_PERMITIDO = EDAD_PERSONA >= EDAD_MINIMA;

        Console.WriteLine("Edad: " + EDAD_PERSONA);
        Console.WriteLine("Acceso permitido: " + ACCESO_PERMITIDO);

        Console.ReadLine();
    }
}
// ------------------------EJERCICIO N3--------------------------- //
namespace Programa06;

class Program
{
    static void Main(string[] args)
    {
        const string PLATAFORMA = "EduOnline";
        const int EDAD_MINIMA = 13;

        Console.WriteLine("=== " + PLATAFORMA + " ===");

        const int EDAD_USUARIO = 12;
        const bool PUEDE_REGISTRARSE = EDAD_USUARIO >= EDAD_MINIMA;

        Console.WriteLine("Edad usuario: " + EDAD_USUARIO);
        Console.WriteLine("¿Puede registrarse?: " + PUEDE_REGISTRARSE);

        Console.ReadLine();
    }
}
// ------------------------EJERCICIO N4--------------------------- //
namespace programa06;

class Program
{
    static void Main(string[] args)
    {
        const string TIENDA = "Market 24";
        const int EDAD_MINIMA = 18;

        Console.WriteLine("=== " + TIENDA + " ===");

        const int EDAD_CLIENTE = 17;
        const bool PUEDE_COMPRAR = EDAD_CLIENTE >= EDAD_MINIMA;

        Console.WriteLine("Cliente: " + EDAD_CLIENTE + " años");
        Console.WriteLine("¿Puede comprar?: " + PUEDE_COMPRAR);

        Console.ReadLine();
    }
}
// ------------------------EJERCICIO N5--------------------------- //
namespace Programa06;

class Program
{
    static void Main(string[] args)
    {
        const string JUEGO = "BattleZone";
        const int EDAD_MINIMA = 16;

        Console.WriteLine("=== " + JUEGO + " ===");

        const int EDAD_JUGADOR = 16;
        const bool PUEDE_JUGAR = EDAD_JUGADOR >= EDAD_MINIMA;

        Console.WriteLine("Edad del jugador: " + EDAD_JUGADOR);
        Console.WriteLine("¿Puede jugar?: " + PUEDE_JUGAR);

        Console.ReadLine();
    }
}