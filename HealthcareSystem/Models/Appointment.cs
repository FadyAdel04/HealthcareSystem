using System.ComponentModel.DataAnnotations;

namespace HealthcareSystem.Models
{
public class Appointment
{
    public int AppointmentId { get; set; }
    [Required]
    public int PatientId { get; set; }
    [Required]
    public DateTime AppointmentDate { get; set; }
    [Required]
    [StringLength(100)]
    public string DoctorName { get; set; }
    [StringLength(250)]
    public string Reason { get; set; }
    public Patient Patient { get; set; }
}
}
