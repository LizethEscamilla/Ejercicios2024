public struct Point
{
    public short X { get; set; }
    public short Y { get; set; }
    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }

    public Point(short x, short y, byte r, byte g, byte b)
    {
        X = x;
        Y = y;
        R = r;
        G = g;
        B = b;
    }

    public override string ToString()
    {
        return $"Point (X: {X}, Y: {Y}), Color: (R:{R}, G:{G}, B:{B})";
    }
}
