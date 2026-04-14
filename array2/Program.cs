// _____________-- EJERCICIO 1_______________________//
using System;

namespace GuiaArreglos
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EJERCICIO 2: INICIALIZACIÓN DIRECTA Y FOREACH ---");

            // 1. Inicialización directa
            string[] frutas = { "PERA", "PALTA", "UVA", "TOMATE" };

            Console.WriteLine("Lista de frutas usando foreach:");

            // 2. Recorrido con foreach
            foreach (string fruta in frutas)
            {
                Console.WriteLine("- " + fruta);
            }

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
// _____________-- EJERCICIO 2_______________________//
using System;

class Ejercicio1
{
    static void Main()
    {
        int[] numeros = { 5, 10, 15, 20, 25 };

        Console.WriteLine("Lista de números:");

        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }

        Console.ReadLine();
    }
}
// _____________-- EJERCICIO 3_______________________//
using System;

class Ejercicio2
{
    static void Main()
    {
        string[] nombres = { "Juan", "Ana", "Luis", "María" };

        Console.WriteLine("Lista de nombres:");

        foreach (string nombre in nombres)
        {
            Console.WriteLine("Hola " + nombre);
        }

        Console.ReadLine();
    }
}
// _____________-- EJERCICIO 4_______________________//
using System;

class Ejercicio3
{
    static void Main()
    {
        double[] precios = { 100.5, 250.75, 300, 150.25 };

        Console.WriteLine("Precios de productos:");

        foreach (double precio in precios)
        {
            Console.WriteLine("$" + precio);
        }

        Console.ReadLine();
    }
}
// _____________-- EJERCICIO 5_______________________//
using System;

class Ejercicio4
{
    static void Main()
    {
        string[] materias = { "Matemática", "Programación", "Inglés", "Física" };

        Console.WriteLine("Mis materias:");

        foreach (string materia in materias)
        {
            Console.WriteLine("- " + materia);
        }

        Console.ReadLine();
    }
}