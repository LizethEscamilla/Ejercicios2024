public class StudentAndTeacherTest
{
    public static void Main(string[] args)
    {
        Person person = new Person("María");
        person.Greet();

        Student student = new Student("Juan");
        student.SetAge(21);
        student.Greet();
        student.ShowAge();
        student.GoToClasses();

        Teacher teacher = new Teacher("José", "Chemistry");
        teacher.SetAge(30);
        teacher.Greet();
        teacher.Explain();
    }
}