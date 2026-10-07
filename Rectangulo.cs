class Rectangulo
{
    private double ancho;
    private double alto;

    public Rectangulo(double ancho, double alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    public double Area()
    {
        return ancho * alto;
    }

    public double Perimetro()
    {
        return 2 * (ancho + alto);
    }
}