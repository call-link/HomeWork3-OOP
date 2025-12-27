namespace HospitalManagement.Models;

public class Doctor : Person
{
    public int DoctorId { get; set; }
    public string Specialization { get; set; }

    public Doctor(string name, int age, string nationalId, int doctorId, string specialization)
        : base(name, age, nationalId)
    {
        DoctorId = doctorId;
        Specialization = specialization;
    }

    public void Diagnose(Patient patient, string diagnosis)
    {
        patient.AddToMedicalHistory(diagnosis);
    }

    public override string GetDetails()
    {
        return base.GetDetails() + $", DoctorId: {DoctorId}, Specialization: {Specialization}";
    }
}
