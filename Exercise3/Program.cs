class Program
{
    static void Main()
    {
        Console.Write("Ingresa el primer número: ");
        int num1= Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Ingresa el segundo número: ");
        int num2=Convert.ToInt32(Console.ReadLine());
        
        AbsoluteValue Absvalue =new AbsoluteValue();
        int result =Absvalue.GetAbsolute(num1, num2);
        
        Console.WriteLine("El resultado es: " + result);
    }
}
