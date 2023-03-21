using Ginkoya.MaintenanceManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ginkoya.MaintenanceManager.Data.Configurations
{
    public class WorkConfiguration : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            builder.HasKey(work => work.Id);

            builder.HasOne(work => work.Equipment)
                   .WithMany(equipment => equipment.Works)
                   .HasForeignKey(work => work.EquipmentId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(work => work.WorkType)
                   .WithMany(t => t.Works)
                   .HasForeignKey(work => work.WorkTypeId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
