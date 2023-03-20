using Ginkoya.MaintenanceManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ginkoya.MaintenanceManager.Data.Configurations
{
    public class EquipmentConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.HasKey(equipment => equipment.Id);

            builder.HasOne(equipment => equipment.Customer)
                   .WithMany(customer => customer.Equipments)
                   .HasForeignKey(equipment => equipment.CustomerId);

            builder.HasOne(equipment => equipment.Type)
                   .WithMany(type => type.Equipments)
                   .HasForeignKey(equipment => equipment.TypeId);
        }
    }
}
