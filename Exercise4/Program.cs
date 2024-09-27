class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa la base del rectángulo: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la altura del rectángulo: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(width, height);

        double perimeter = rectangle.CalcPerimeter();
        double area = rectangle.CalcArea();
        double diagonal = rectangle.CalcDiagonal();

        Console.WriteLine($"Perimeter: {perimeter}");
        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Diagonal: {diagonal}");
    }
}


