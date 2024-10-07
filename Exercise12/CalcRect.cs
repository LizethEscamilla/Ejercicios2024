public class CalcRect
{
    public static Rectangulo CalcularRectangulo(int largo, int ancho)
    {
        Rectangulo rect;
        rect.Largo = largo;
        rect.Ancho = ancho;
        rect.Perimetro = 2 * (largo + ancho);
        rect.Area = largo * ancho;
        return rect;
    }
}
