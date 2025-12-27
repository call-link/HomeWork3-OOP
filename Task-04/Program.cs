using HospitalManagement.Models;

Hospital hospital = new Hospital();

hospital.Rooms.Add(new Room(101, 2));
hospital.Rooms.Add(new Room(102, 1));

Doctor doctor = new Doctor("Dr. Ali", 45, "1234567890", 1, "Cardiology");
hospital.Doctors.Add(doctor);

Patient p1 = new Patient("Reza", 30, "111", 1001);
Patient p2 = new Patient("Sara", 25, "222", 1002);
Patient p3 = new Patient("Nima", 40, "333", 1003);

hospital.AdmitPatient(p1);
hospital.AdmitPatient(p2);
hospital.AdmitPatient(p3);

doctor.Diagnose(p1, "Flu");

Console.WriteLine(string.Join(", ", p1.MedicalHistory));
