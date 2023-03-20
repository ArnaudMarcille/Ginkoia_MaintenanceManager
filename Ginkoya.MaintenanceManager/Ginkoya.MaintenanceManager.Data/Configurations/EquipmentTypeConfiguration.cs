using Ginkoya.MaintenanceManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ginkoya.MaintenanceManager.Data.Configurations
{
    public class EquipmentTypeConfiguration : IEntityTypeConfiguration<EquipmentType>
    {
        public void Configure(EntityTypeBuilder<EquipmentType> builder)
        {
            builder.HasKey(equipmentType => equipmentType.Id);
        }
    }
}
