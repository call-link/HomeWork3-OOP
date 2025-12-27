namespace UniversitySystem.Models;

public class Professor : Person
{
    public string ProfessorID { get; set; }
    public string Subject { get; set; }

    public Professor(string name, int age, string professorId, string subject)
        : base(name, age)
    {
        ProfessorID = professorId;
        Subject = subject;
    }

    public override string GetDetails()
    {
        return $"Professor -> Name: {Name}, Age: {Age}, ID: {ProfessorID}, Subject: {Subject}";
    }
}
