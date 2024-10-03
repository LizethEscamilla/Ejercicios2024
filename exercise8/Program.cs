class Program
{
    static void Main()
    {
        int resultado = Power(2, 3);  
        Console.WriteLine(resultado);
    }

    static int Power(int Numbase, int exponente)
    {
        int resultado = 1;  
        for (int i = 0; i < exponente; i++)
        {
            resultado *= Numbase;  
        }
        return resultado;  
    }
}

