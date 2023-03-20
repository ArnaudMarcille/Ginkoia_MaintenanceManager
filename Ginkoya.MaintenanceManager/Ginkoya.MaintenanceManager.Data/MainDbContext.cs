using System.Diagnostics.CodeAnalysis;
using Ginkoya.MaintenanceManager.Core.Entities;
using Ginkoya.MaintenanceManager.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Ginkoya.MaintenanceManager.Data
{
    /// <summary>
    /// Application DB Context
    /// </summary>
    public class MainDbContext : DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options"></param>
        public MainDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }

        /// <summary>
        /// Define all configuration for tables
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CatalogProductConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new EquipmentConfiguration());
            modelBuilder.ApplyConfiguration(new EquipmentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WorkChangedPartConfiguration());
            modelBuilder.ApplyConfiguration(new WorkConfiguration());
            modelBuilder.ApplyConfiguration(new WorkTypeConfiguration());
        }

        public DbSet<CatalogProduct> CatalogProducts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<WorkChangedPart> WorkChangedParts { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<WorkType> WorkTypes { get; set; }
    }
}
