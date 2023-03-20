namespace Ginkoya.MaintenanceManager.Data
{
    public interface IDBContextFactory
    {
        MainDbContext CreateDbContext();
    }
}