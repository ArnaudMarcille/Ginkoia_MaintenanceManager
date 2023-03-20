using Ginkoya.MaintenanceManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ginkoya.MaintenanceManager.Data.Configurations
{
    public class CatalogProductConfiguration : IEntityTypeConfiguration<CatalogProduct>
    {
        public void Configure(EntityTypeBuilder<CatalogProduct> builder)
        {
            builder.HasKey(catalogProduct => catalogProduct.Id);
        }
    }
}
