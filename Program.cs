using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // 1. EJERCICIO DE CONSTRUCTORES


        Console.WriteLine("=== CONSTRUCTORES ===");

        Usuario usuario1 = new Usuario();

        Usuario usuario2 = new Usuario("Hola, que hace");

        ArrayList lista = new ArrayList();

        lista.Add("Diego");
        lista.Add("David");
        lista.Add("Kevin");

        Usuario usuario3 = new Usuario(lista);


        // 2. EJERCICIO DE COPIAR / CLONAR

        Console.WriteLine("\n=== COPIAR / CLONAR ===");

        var a = new Punto(1, 2);
        var b = a;
        var c = a.Clonar();

        a.X = 99;

        Console.WriteLine($"{b.X} {c.X}");

        // 3. EJERCICIO DE LIBROS

        Console.WriteLine("\n=== LIBROS ===");

        var l1 = new Libro("Cien años de soledad", "García Márquez");
        var l2 = new Libro("El coronel no tiene quien le escriba");

        l1.Prestar();

        Console.WriteLine(l1.Descripcion());
        Console.WriteLine(l2.Descripcion());


        // 4. EJERCICIO DE MASCOTA

        Console.WriteLine("\n=== MASCOTA ===");

        var gato = new Mascota("Misu", 3);

        gato.Presentarse();


        // 5. EJERCICIO DE SALUDO

        Console.WriteLine("\n=== SALUDO ===");

        Console.WriteLine(new Saludo().Decir("DIego"));

        // 6. EJERCICIO DE RECTANGULO

        Console.WriteLine("\n=== RECTANGULO ===");

        var r = new Rectangulo(3, 4);

        Console.WriteLine($"Área: {r.Area()}");
        Console.WriteLine($"Perímetro: {r.Perimetro()}");
    }
}