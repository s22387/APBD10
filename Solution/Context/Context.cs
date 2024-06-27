using Microsoft.EntityFrameworkCore;
using Solution.Configuration;
using Solution.Model;

namespace Solution.Context;

public class Context : DbContext
{
    private IConfiguration _configuration;

    public Context(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public Context(DbContextOptions options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:DefaultConnection"]);
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new DoctorConfiguration());
        modelBuilder.ApplyConfiguration(new MedicamentConfiguration());
        modelBuilder.ApplyConfiguration(new PatientConfiguration());
        modelBuilder.ApplyConfiguration(new PrescriptionConfiguration());
        modelBuilder.ApplyConfiguration(new PrescriptionMedicamentConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguraion());
    }
    
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Medicament> Medicaments { get; set; }
    public DbSet<Prescription_Medicament> PrescriptionMedicaments { get; set; }
    
    public DbSet<User> Users { get; set; }
}