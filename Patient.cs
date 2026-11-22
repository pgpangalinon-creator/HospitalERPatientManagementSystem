namespace HospitalERPatientManagementSystem
{
    public class Patient
    {
        private int patientId;
        private string name;
        private int age;
        private string complaint;
        private string priorityLevel;

        public Patient(int patientId, string name, int age, string complaint, string priorityLevel)
        {
            this.patientId = patientId;
            this.name = name;
            this.age = age;
            this.complaint = complaint;
            this.priorityLevel = priorityLevel;
        }

        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Complaint
        {
            get { return complaint; }
            set { complaint = value; }
        }

        public string PriorityLevel
        {
            get { return priorityLevel; }
            set { priorityLevel = value; }
        }
    }

}