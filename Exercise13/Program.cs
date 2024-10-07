class Program
{
    static void Main(string[] args)
    {
        Fighter fighter = new Fighter("Mario Torres", 215);

        Console.WriteLine($"Nombre: {fighter.Name}");
        Console.WriteLine($"Peso: {fighter.Weight} lbs");
        Console.WriteLine($"Categoría: {fighter.Category}");
    }
}
