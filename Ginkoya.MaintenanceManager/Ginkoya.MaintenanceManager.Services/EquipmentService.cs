using Ginkoya.MaintenanceManager.Core.Entities;
using Ginkoya.MaintenanceManager.Data;

namespace Ginkoya.MaintenanceManager.Services
{
    /// <summary>
    /// Equipment service
    /// </summary>
    public class EquipmentService : BaseDBService
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="factory"></param>
        public EquipmentService(IDBContextFactory factory) : base(factory)
        {
        }

        public int Create(string label, string serialNumber, int typeId, int customerId)
        {
            Equipment equipment = new Equipment
            {
                Label = label,
                SerialNumber = serialNumber,
                TypeId = typeId,
                CustomerId = customerId
            };

            DbContext.Add(equipment);
            DbContext.SaveChanges();

            return equipment.Id;
        }
    }
}
