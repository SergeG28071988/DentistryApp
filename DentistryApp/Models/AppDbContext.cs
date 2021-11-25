using System.Data.Entity;

namespace DentistryApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("Dentistry") { }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Coupon> Coupons { get; set; } 
    }
}
