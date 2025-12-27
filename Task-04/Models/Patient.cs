namespace HospitalManagement.Models;

public class Patient : Person
{
    public int PatientId { get; set; }
    public List<string> MedicalHistory { get; }

    public Patient(string name, int age, string nationalId, int patientId)
        : base(name, age, nationalId)
    {
        PatientId = patientId;
        MedicalHistory = new List<string>();
    }

    public void AddToMedicalHistory(string disease)
    {
        MedicalHistory.Add(disease);
    }

    public override string GetDetails()
    {
        return base.GetDetails() + $", PatientId: {PatientId}";
    }
}
