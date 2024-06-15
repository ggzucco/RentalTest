using Microsoft.EntityFrameworkCore;
using RentalTest.Models;

namespace RentalTest.Context
{
    public partial class RentalContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public RentalContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {            
            options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<CategoryModel> Category { get; set; }
        public DbSet<EquipmentModel> Equipment { get; set; }
        public DbSet<StatusModel> Status { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryModel>(entity =>
            {
                entity.HasKey(e => e.CategoryId);
                
                entity.Property(e => e.CategoryId).IsRequired().ValueGeneratedOnAdd();               
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<EquipmentModel>(entity =>
            {
                entity.HasKey(e => e.EquipmentId);
                entity.Property(e => e.EquipmentId).IsRequired().ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Location).IsRequired().HasMaxLength(100);
                entity.Property(e => e.LastMaintenanceDate).IsRequired();
                entity.Property(e => e.RentalRate).IsRequired();
                entity.HasOne(e => e.Category).WithMany(c => c.Equipments).HasForeignKey(e => e.CategoryId);
                entity.HasOne(e => e.Status).WithMany(s => s.Equipments).HasForeignKey(e => e.StatusId);
            });

            modelBuilder.Entity<StatusModel>(entity =>
            {
                entity.HasKey(e => e.StatusId);
                entity.Property(e => e.StatusId).IsRequired().ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired();
            });
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
