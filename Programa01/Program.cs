using System;

namespace Program01;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- SISTEMA DE REGISTRO DE USUARIO ---");

        Console.Write("Por favor, ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingresa tu edad: ");
        string edaddtexto = Console.ReadLine();
      

        int edad;
        if (!int.TryParse(edadTexto, out edad))
        {
            Console.WriteLine("Edad inválida.");
            return;
        }

        Console.Write("Ingresa tu estatura (ejemplo: 1.75): ");
        double estatura = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

        Console.WriteLine("\n--- PERFIL CREADO ---");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad el próximo año: " + (edad + 1));
        Console.WriteLine("Estatura: " + estatura + " metros");

        Console.WriteLine("\nPresiona ENTER para salir.");
        Console.ReadLine();
    }
}