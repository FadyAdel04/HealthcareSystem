using System;
using System.ComponentModel.DataAnnotations;

namespace HealthcareSystem.Models
{
    /// <summary>
    /// Represents an appointment in the healthcare system.
    /// </summary>
    public class Appointment
    {
        /// <summary>
        /// Gets or sets the unique identifier for the appointment.
        /// </summary>
        public int AppointmentId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the patient associated with the appointment.
        /// </summary>
        [Required]
        public int PatientId { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the appointment.
        /// </summary>
        [Required]
        public DateTime AppointmentDate { get; set; }

        /// <summary>
        /// Gets or sets the name of the doctor for the appointment.
        /// </summary>
        [Required]
        [StringLength(100)]
        public string DoctorName { get; set; }

        /// <summary>
        /// Gets or sets the reason for the appointment.
        /// </summary>
        [StringLength(250)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets the patient associated with the appointment.
        /// </summary>
        public Patient Patient { get; set; }
    }
}