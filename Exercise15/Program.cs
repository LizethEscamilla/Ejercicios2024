class Program
{
    static void Main()
    {
        DicStudent dicStudent = new DicStudent();
        int schoolNumber = 21040007;

        string result = dicStudent.FindStudent(schoolNumber);
        Console.WriteLine(result);
    }
}

