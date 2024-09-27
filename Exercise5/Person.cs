public class Person
{
    public string Name { get; set; }
    private int Age { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public void SetAge(int age)
    {
        Age = age;
    }

    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name}.");
    }

    public void ShowAge()
    {
        Console.WriteLine($"My age is: {Age} years old.");
    }
}
