using Ginkoya.MaintenanceManager.Data;
using Ginkoya.MaintenanceManager.Services.Interfaces;

namespace Ginkoya.MaintenanceManager.Services
{
    public abstract class BaseDBService : IService
    {
        /// <summary>
        /// Main db context
        /// </summary>
        protected readonly MainDbContext DbContext;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="factory"></param>
        public BaseDBService(IDBContextFactory factory)
        {
            DbContext = factory.CreateDbContext();
        }

    }
}
