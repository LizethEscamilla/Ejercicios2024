class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa los datos del primer punto:");
        Point point1 = CreatePoint();

        Console.WriteLine("\nIngresa los datos del segundo punto:");
        Point point2 = CreatePoint();

        Console.WriteLine("\nPrimer punto:");
        Console.WriteLine(point1);

        Console.WriteLine("\nSegundo punto:");
        Console.WriteLine(point2);
    }

    static Point CreatePoint()
    {
        Console.Write("Ingresa la coordenada X (short): ");
        short x = Convert.ToInt16(Console.ReadLine());

        Console.Write("Ingresa la coordenada Y (short): ");
        short y = Convert.ToInt16(Console.ReadLine());

        Console.Write("Ingresa el valor rojo (byte): ");
        byte r = Convert.ToByte(Console.ReadLine());

        Console.Write("Ingresa el valor verde (byte): ");
        byte g = Convert.ToByte(Console.ReadLine());

        Console.Write("Ingresa el valor azul (byte): ");
        byte b = Convert.ToByte(Console.ReadLine());

        return new Point(x, y, r, g, b);
    }
}

