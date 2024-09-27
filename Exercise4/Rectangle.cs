public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalcPerimeter()
    {
        return (Width + Height) *2;
    }

    public double CalcArea()
    {
        return Width * Height;
    }

    public double CalcDiagonal()
    {
        return Math.Sqrt(Width * Width + Height * Height);
    }
}
