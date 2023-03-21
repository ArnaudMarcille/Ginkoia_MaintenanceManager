using Ginkoya.MaintenanceManager.Core.Models;
using Ginkoya.MaintenanceManager.Data;

namespace Ginkoya.MaintenanceManager.Services
{
    /// <summary>
    /// Equipment type service
    /// </summary>
    public class EquipmentTypeService : BaseDBService
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="factory"></param>
        public EquipmentTypeService(IDBContextFactory factory) : base(factory)
        {
        }

        /// <summary>
        /// Get all equipment types
        /// </summary>
        /// <returns></returns>
        public List<EquipmentTypeModel> GetAll()
        {
            List<EquipmentTypeModel> equipmentTypeModels = new List<EquipmentTypeModel>();

            // Get db entities
            var entities = DbContext.EquipmentTypes.ToList();

            foreach (var entity in entities)
            {
                equipmentTypeModels.Add(new EquipmentTypeModel()
                {
                    Id = entity.Id,
                    Label = entity.Label,
                });
            }

            return equipmentTypeModels;
        }
    }
}
