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

        public DbSet<EquipmentModel> Equipment { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {          
            modelBuilder.Entity<EquipmentModel>(entity =>
            {
                entity.HasKey(e => e.EquipmentId);
                entity.Property(e => e.EquipmentId).IsRequired().ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Location).IsRequired().HasMaxLength(100);
                entity.Property(e => e.LastMaintenanceDate).IsRequired();
                entity.Property(e => e.RentalRate).IsRequired();
                entity.Property(e => e.CategoryId).IsRequired();
                entity.Property(e => e.StatusId).IsRequired();
            });           
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
