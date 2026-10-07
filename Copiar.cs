class Punto
{
    public int X;
    public int Y;

    public Punto(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Punto Clonar()
    {
        return new Punto(X, Y);
    }
}