using HealthcareSystem.Models;
using Microsoft.EntityFrameworkCore;

public class HealthcareContext : DbContext, IHealthcareContext
{
    public HealthcareContext(DbContextOptions<HealthcareContext> options) : base(options) { }

    public DbSet<Patient> Patients { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<MedicalRecord> MedicalRecords { get; set; }
    public DbSet<Billing> Billings { get; set; }
    public DbSet<Pharmacy> Pharmacies { get; set; }
    public DbSet<Staff> Staffs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Billing>().HasKey(b => b.BillId);
        modelBuilder.Entity<Patient>().HasKey(p => p.PatientId);
        modelBuilder.Entity<Appointment>().HasKey(a => a.AppointmentId);
        modelBuilder.Entity<MedicalRecord>().HasKey(m => m.RecordId);
        modelBuilder.Entity<Pharmacy>().HasKey(p => p.PrescriptionId);
        modelBuilder.Entity<Staff>().HasKey(s => s.StaffId);
    }
}
