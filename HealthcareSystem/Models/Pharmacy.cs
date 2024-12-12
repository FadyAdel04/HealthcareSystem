namespace HealthcareSystem.Models
{
    public class Pharmacy
    {
        public int PrescriptionId { get; set; }
        public int PatientId { get; set; }
        public string Medicine { get; set; }
        public string Dosage { get; set; }
        public DateTime IssuedDate { get; set; }

        // Navigation property
        public Patient Patient { get; set; }
    }
}
