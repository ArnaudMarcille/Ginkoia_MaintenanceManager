using Ginkoya.MaintenanceManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ginkoya.MaintenanceManager.Data.Configurations
{
    public class WorkChangedPartConfiguration : IEntityTypeConfiguration<WorkChangedPart>
    {
        public void Configure(EntityTypeBuilder<WorkChangedPart> builder)
        {
            builder.HasKey(part => part.Id);

            builder.HasOne(part => part.Work)
                   .WithMany(work => work.WorkChangedParts)
                   .HasForeignKey(part => part.WorkId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(part => part.Product)
                   .WithMany()
                   .HasForeignKey(part => part.ProductId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
