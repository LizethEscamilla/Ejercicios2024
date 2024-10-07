class Program
{
    static void Main(string[] args)
    {
        Book[] books = new Book[2];

        Console.WriteLine("\nIngresa la información de libro 1:");
        books[0] = CreateBookFromUserInput();

        Console.WriteLine("\nIngresa la información de libro 2:");
        books[1] = CreateBookFromUserInput();

        Console.WriteLine($"\n1: {books[0]}");
        Console.WriteLine($"2: {books[1]}");
    }

    static Book CreateBookFromUserInput()
    {
        Console.Write("Ingresa el nombre del libro: ");
        string title = Console.ReadLine();

        Console.Write("Ingresa el autor: ");
        string author = Console.ReadLine();

        return new Book(title, author);
    }
}

