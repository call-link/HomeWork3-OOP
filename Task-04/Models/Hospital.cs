namespace HospitalManagement.Models;

public class Hospital
{
    public List<Doctor> Doctors { get; }
    public List<Room> Rooms { get; }

    public Hospital()
    {
        Doctors = new List<Doctor>();
        Rooms = new List<Room>();
    }

    public void AdmitPatient(Patient patient)
    {
        foreach (Room room in Rooms)
        {
            try
            {
                room.AssignPatient(patient);
                Console.WriteLine($"Patient admitted to room {room.RoomNumber}");
                return;
            }
            catch
            {
                // اتاق پر است → برو اتاق بعدی
            }
        }

        Console.WriteLine("No available room for the patient!");
    }

    public void DischargePatient(Patient patient)
    {
        foreach (Room room in Rooms)
        {
            if (room.Patients.Contains(patient))
            {
                room.RemovePatient(patient);
                Console.WriteLine("Patient discharged.");
                return;
            }
        }
    }
}
