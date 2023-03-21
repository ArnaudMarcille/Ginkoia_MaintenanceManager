using Ginkoya.MaintenanceManager.Core.Entities;
using Ginkoya.MaintenanceManager.Core.Models;
using Ginkoya.MaintenanceManager.Data;
using Microsoft.EntityFrameworkCore;

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

        /// <summary>
        /// Return all the work item 
        /// </summary>
        /// <returns></returns>
        public List<WorkListItemModel> ListWork()
        {
            List<WorkListItemModel> workListItemModels = new List<WorkListItemModel>();
            var entities = DbContext.Works.Include(w => w.WorkType)
                                          .Include(w => w.Equipment)
                                            .ThenInclude(e => e.Customer)
                                          .Include(w => w.Equipment)
                                            .ThenInclude(e => e.Type).ToList();

            foreach (var entity in entities)
            {
                workListItemModels.Add(new WorkListItemModel()
                {
                    CustomerFullName = entity.Equipment.Customer.FirstName + " " + entity.Equipment.Customer.LastName,
                    TechnicianName = entity.Technician,
                    EquipmentLabel = entity.Equipment.Label,
                    EquipmentTypeLabel = entity.Equipment.Type.Label,
                    Duration = entity.Duration,
                    Price = entity.FinalPrice,
                    WorkLabel = entity.Label,
                    WorkTypeLabel = entity.WorkType.Label,
                });
            }
            return workListItemModels;
        }
    }
}
