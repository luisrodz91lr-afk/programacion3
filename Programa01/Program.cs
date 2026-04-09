using System;

namespace Programa_01
{// EJERCICIO  N1 REGISTRO DE SISTEMAS //
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- SISTEMA DE REGISTRO DE EMPLEADO ---");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Puesto: ");
            string puesto = Console.ReadLine();

            Console.Write("Sueldo: ");
            double sueldo = double.Parse(Console.ReadLine());

            Console.WriteLine("\n--- EMPLEADO REGISTRADO ---");
            Console.WriteLine($"Nombre completo: {nombre} {apellido}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Puesto: {puesto}");
            Console.WriteLine($"Sueldo: {sueldo}");

            Console.ReadLine();
        }
    }
}
// EJERCICIO N2 REGISTRO DE PACIENTES //
using System;

namespace Programa_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- REGISTRO DE PACIENTE ---");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("\n--- DATOS DEL PACIENTE ---");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"IMC: {imc:F2}");

            Console.ReadLine();
        }
    }
}
// EJERCICIOS N3 REGISTROS DE PRODUCTOS//
using System;

namespace Programa_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- REGISTRO DE PRODUCTO ---");

            Console.Write("Nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Precio: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());

            double total = precio * cantidad;

            Console.WriteLine("\n--- DETALLE DE COMPRA ---");
            Console.WriteLine($"Producto: {nombre}");
            Console.WriteLine($"Total a pagar: {total}");

            Console.ReadLine();
        }
    }
}
// EJERCICIO N4 REGISTRO DE VEHICULOS//
using System;

namespace Programa_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- REGISTRO DE VEHÍCULO ---");

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Año: ");
            int anio = int.Parse(Console.ReadLine());

            Console.Write("Kilómetros: ");
            int km = int.Parse(Console.ReadLine());

            Console.WriteLine("\n--- VEHÍCULO REGISTRADO ---");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Año: {anio}");
            Console.WriteLine($"KM: {km}");

            Console.ReadLine();
        }
    }
}
// EJERCICIOS N5 REGISTRO DE USUARIO //
using System;

namespace Programa_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- REGISTRO DE USUARIO ---");

            Console.Write("Usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Contraseña: ");
            string clave = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("\n--- USUARIO REGISTRADO ---");
            Console.WriteLine($"Usuario: {usuario}");
            Console.WriteLine($"Email: {email}");

            Console.ReadLine();
        }
    }
}
