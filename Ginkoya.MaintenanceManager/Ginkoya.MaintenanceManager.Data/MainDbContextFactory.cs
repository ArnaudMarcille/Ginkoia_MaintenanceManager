using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Ginkoya.MaintenanceManager.Data
{
    public class MainDbContextFactory : IDesignTimeDbContextFactory<MainDbContext>, IDBContextFactory
    {
        #region Public methods

        public MainDbContext CreateDbContext(string[] args)
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

            var configuration = configurationBuilder.Build();
            DbContextOptionsBuilder builder = new DbContextOptionsBuilder().UseSqlServer(configuration.GetConnectionString("MainDb"));

            MainDbContext context = new MainDbContext(builder.Options);

            return context;
        }

        public MainDbContext CreateDbContext()
        {
            return CreateDbContext(Array.Empty<string>());
        }

        #endregion
    }
}
