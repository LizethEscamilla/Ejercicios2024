public class DicStudent
{
    private Dictionary<int, string> students;
    public DicStudent()
    {
        students = new Dictionary<int, string>
        {
            { 21040007, "Lizeth Escamilla" },
            { 21040166, "Michelle Ibarra" },
            { 21040009, "Marisol Castro" }
        };
    }
    public string FindStudent(int schoolNumber)
    {
        if (students.TryGetValue(schoolNumber, out string name))
        {
            return $"El estudiante con número escolar {schoolNumber} es {name}.";
        }
        else
        {
            return $"No se encontró un estudiante con el número escolar {schoolNumber}.";
        }
    }
}
