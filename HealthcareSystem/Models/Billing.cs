using HealthcareSystem.Models;

public class Billing
{
    public int BillId { get; set; } // Primary Key
    public int PatientId { get; set; }
    public decimal Amount { get; set; }
    public DateTime BillDate { get; set; }
    public string Status { get; set; }

    // Navigation property
    public Patient Patient { get; set; }
}
