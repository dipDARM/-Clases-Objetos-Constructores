using System;
using System.Collections;

class Usuario
{
    public Usuario()
    {
        Console.WriteLine("Soy el constructor void");
    }

    public Usuario(string mensaje)
    {
        Console.WriteLine(mensaje);
    }

    public Usuario(ArrayList lista)
    {
        foreach (var elemento in lista)
        {
            Console.WriteLine(elemento);
        }
    }
}