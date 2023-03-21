using Ginkoya.MaintenanceManager.Core.Models;
using Ginkoya.MaintenanceManager.Data;

namespace Ginkoya.MaintenanceManager.Services
{
    public class WorkTypesService : BaseDBService
    {
        public WorkTypesService(IDBContextFactory factory) : base(factory)
        {
        }

        /// <summary>
        /// Get work type for equipment type
        /// </summary>
        /// <param name="equipmentType"></param>
        /// <returns></returns>
        public List<WorkTypeModel> GetWorkTypesFor(int equipmentType)
        {
            List<WorkTypeModel> workTypeModels = new List<WorkTypeModel>();

            //Get entities
            var entities = DbContext.WorkTypes
                                    .Where(workType => workType.EquipmentTypeId == equipmentType)
                                    .ToList();

            foreach (var entity in entities)
            {
                workTypeModels.Add(new WorkTypeModel()
                {
                    Id = entity.Id,
                    Label = entity.Label,
                    FixedDuration = entity.FixedDuration,
                    HaveFixedPrice = entity.HaveFixedPrice,
                    Price = entity.Price
                });
            }

            return workTypeModels;
        }
    }
}
