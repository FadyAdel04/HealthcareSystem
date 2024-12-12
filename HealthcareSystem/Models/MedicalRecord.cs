namespace HealthcareSystem.Models
{
    public class MedicalRecord
    {
        public int RecordId { get; set; }
        public int PatientId { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public DateTime RecordDate { get; set; }

        // Navigation property
        public Patient Patient { get; set; }
    }
}
