using Ginkoya.MaintenanceManager.Core.Entities;
using Ginkoya.MaintenanceManager.Data;

namespace Ginkoya.MaintenanceManager.Services
{
    public class WorkService : BaseDBService
    {
        public WorkService(IDBContextFactory factory) : base(factory)
        {
        }

        /// <summary>
        /// Create a work and return its id
        /// </summary>
        /// <param name="label"></param>
        /// <param name="date"></param>
        /// <param name="technician"></param>
        /// <param name="duration"></param>
        /// <param name="finalPrice"></param>
        /// <param name="equipmentId"></param>
        /// <param name="workTypeId"></param>
        /// <returns></returns>
        public int Create(string label, DateTime date, string technician, int duration, int finalPrice, int equipmentId, int workTypeId)
        {

            Work work = new Work()
            {
                Label = label,
                Date = date,
                Technician = technician,
                Duration = duration,
                FinalPrice = finalPrice,
                EquipmentId = equipmentId,
                WorkTypeId = workTypeId
            };

            DbContext.Add(work);

            DbContext.SaveChanges();
            return work.Id;
        }
    }
}
