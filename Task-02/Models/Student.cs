namespace UniversitySystem.Models;

public class Student : Person
{
    public string StudentID { get; set; }
    public string Major { get; set; }

    public Student(string name, int age, string studentId, string major)
        : base(name, age)
    {
        StudentID = studentId;
        Major = major;
    }

    public override string GetDetails()
    {
        return $"Student -> Name: {Name}, Age: {Age}, ID: {StudentID}, Major: {Major}";
    }
}
    