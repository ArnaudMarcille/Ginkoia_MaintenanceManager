using Ginkoya.MaintenanceManager.Core.Models;
using Ginkoya.MaintenanceManager.Services.Interfaces;

namespace Ginkoya.MaintenanceManager.Services
{
    /// <summary>
    /// Work helper
    /// </summary>
    public class WorkHelper : IService
    {

        #region Fields

        private readonly WorkService workService;
        private readonly CustomerService customerService;
        private readonly EquipmentService equipmentService;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="workService"></param>
        /// <param name="customerService"></param>
        /// <param name="equipmentService"></param>
        public WorkHelper(WorkService workService,
                          CustomerService customerService,
                          EquipmentService equipmentService)
        {
            this.workService = workService;
            this.equipmentService = equipmentService;
            this.customerService = customerService;
        }

        #endregion

        #region Public Methods

        public void SaveWork(NewWorkModel model)
        {
            // Create customer
            int customerId = customerService.Create(model.LastName, model.FirstName, model.Phone, model.Mail);

            // Create Equipment
            int equipmentId = equipmentService.Create(model.EquipmentLabel, model.SerialNumber, model.TypeId, customerId);

            // Create work
            workService.Create(model.WorkLabel, model.Date, model.Technician, model.Duration, model.FinalPrice, equipmentId, model.WorkTypeId);
        }

        #endregion
    }
}
