public class Teacher : Person
{
    private string subject;

    public Teacher(string name, string subject) : base(name)
    {
        this.subject = subject;
    }

    public void Explain()
    {
        Console.WriteLine("Explanation begins.");
    }
}
