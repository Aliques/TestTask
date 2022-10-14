using HospitalTestTask.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalTestTask.Infrastructure
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
          : base(options)
        { }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DistrictPart>(entity =>
            {
                entity.HasKey(o => o.Id);
                entity.Property(o => o.Id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(o => o.Id);
                entity.Property(o => o.FullName).IsRequired();
                entity.HasOne(o => o.Office);
                entity.HasOne(o => o.DistrictPart);
                entity.HasOne(o => o.Specialization);
                entity.Property(o => o.Id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<Office>(entity =>
            {
                entity.HasKey(o => o.Id);
                entity.Property(o => o.Number).IsRequired();
                entity.Property(o => o.Id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(o => o.Id);
                entity.Property(o => o.Name).IsRequired();
                entity.Property(o => o.Surname).IsRequired();
                entity.HasOne(o => o.DistrictPart);
                entity.Property(o => o.Id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<Specialization>(entity =>
            {
                entity.HasKey(o => o.Id);
                entity.Property(o => o.Name).IsRequired();
                entity.Property(o => o.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Office>().HasData(DataBaseSeeder.Offices);
            modelBuilder.Entity<Specialization>().HasData(DataBaseSeeder.Specializations);
            modelBuilder.Entity<DistrictPart>().HasData(DataBaseSeeder.DistrictParts);
            modelBuilder.Entity<Doctor>().HasData(DataBaseSeeder.Doctors);
        }
    }
}