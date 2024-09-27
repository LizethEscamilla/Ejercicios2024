public class Student : Person
{
    public Student(string name) : base(name)
    {
    }

    public void GoToClasses()
    {
        Console.WriteLine("I´m going to class.");
    }
}
