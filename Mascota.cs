class Mascota
{
    private string nombre;
    private int edad;

    public Mascota(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public void Presentarse()
    {
        Console.WriteLine($"Soy {nombre} y tengo {edad} años.");
    }
}

class Saludo
{
    public string Decir(string nombre)
    {
        return $"Hola, {nombre}";
    }
}