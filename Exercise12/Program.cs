class Program
{
    static void Main(string[] args)
    {
        int largo = 20;
        int ancho = 40;

        Rectangulo rect = CalcRect.CalcularRectangulo(largo, ancho);

        Console.WriteLine("Perímetro y área del rectángulo:");
        Console.WriteLine($"Largo: {rect.Largo} Ancho: {rect.Ancho}");
        Console.WriteLine($"Perímetro: {rect.Perimetro} Área: {rect.Area}");
    }
}

