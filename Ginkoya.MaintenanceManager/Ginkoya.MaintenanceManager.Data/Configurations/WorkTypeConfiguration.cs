using Ginkoya.MaintenanceManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ginkoya.MaintenanceManager.Data.Configurations
{
    public class WorkTypeConfiguration : IEntityTypeConfiguration<WorkType>
    {
        public void Configure(EntityTypeBuilder<WorkType> builder)
        {
            builder.HasKey(type => type.Id);

            builder.HasOne(type => type.EquipmentType)
                   .WithMany(equipmentType => equipmentType.WorkTypes)
                   .HasForeignKey(type => type.EquipmentTypeId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
