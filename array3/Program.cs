//________________EJERCICIO1________________________//
using System;

class UsoLengthFor
{
    static void Main()
    {
        Console.WriteLine("--- EJERCICIO 3: USO DE .Length Y BUCLE FOR ---");

        int[] edades = { 15, 22, 30, 18, 25 };

        int cantidadElementos = edades.Length;

        Console.WriteLine("El arreglo tiene " + cantidadElementos + " elementos.");
        Console.WriteLine("-------------------------------------");

        for (int i = 0; i < cantidadElementos; i++)
        {
            Console.WriteLine("Índice " + i + ": La edad es " + edades[i]);
        }

        Console.WriteLine("\nPresione Enter para continuar...");
        Console.ReadLine();
    }
}
//________________EJERCICIO2________________________//
using System;

class Ejercicio1
{
    static void Main()
    {
        int[] numeros = { 2, 4, 6, 8, 10 };

        int cantidad = numeros.Length;

        Console.WriteLine("Cantidad de elementos: " + cantidad);

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Índice " + i + ": " + numeros[i]);
        }

        Console.ReadLine();
    }
}
//________________EJERCICIO3________________________//
using System;

class Ejercicio2
{
    static void Main()
    {
        string[] nombres = { "Pedro", "Lucía", "Carlos", "Sofía" };

        int total = nombres.Length;

        Console.WriteLine("Total de nombres: " + total);

        for (int i = 0; i < total; i++)
        {
            Console.WriteLine("Posición " + i + ": " + nombres[i]);
        }

        Console.ReadLine();
    }
}
//________________EJERCICIO4________________________//
using System;

class Ejercicio3
{
    static void Main()
    {
        int[] valores = { 10, 20, 30, 40 };

        int suma = 0;

        for (int i = 0; i < valores.Length; i++)
        {
            suma = suma + valores[i];
        }

        Console.WriteLine("La suma total es: " + suma);

        Console.ReadLine();
    }
}

//________________EJERCICIO5________________________//
using System;

class Ejercicio4
{
    static void Main()
    {
        int[] edades = { 15, 22, 17, 30, 18 };

        Console.WriteLine("Edades mayores o iguales a 18:");

        for (int i = 0; i < edades.Length; i++)
        {
            if (edades[i] >= 18)
            {
                Console.WriteLine(edades[i]);
            }
        }

        Console.ReadLine();
    }
}