using HospitalERPatientManagementSystem;

Patient patient1 = new Patient(1001, "Juan Dela Cruz", 25, "Fever", "Medium");

Console.WriteLine("=== HOSPITAL PATIENT ===");
Console.WriteLine("Patient ID: " + patient1.PatientId);
Console.WriteLine("Name: " + patient1.Name);
Console.WriteLine("Age: " + patient1.Age);
Console.WriteLine("Complaint: " + patient1.Complaint);
Console.WriteLine("Priority: " + patient1.PriorityLevel);