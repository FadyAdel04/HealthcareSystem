using Microsoft.EntityFrameworkCore;

namespace HealthcareSystem.Models
{
    public class HealthcareContext : DbContext
    {
        public HealthcareContext(DbContextOptions<HealthcareContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }
}
