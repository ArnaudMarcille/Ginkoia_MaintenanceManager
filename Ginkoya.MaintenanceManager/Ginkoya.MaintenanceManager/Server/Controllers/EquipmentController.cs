using Ginkoya.MaintenanceManager.Core.Models;
using Ginkoya.MaintenanceManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ginkoya.MaintenanceManager.Server.Controllers
{
    /// <summary>
    /// Equipment controller
    /// </summary>
    [ApiController]
    [Route("[controller]/[action]")]
    public class EquipmentController : ControllerBase
    {
        #region Fields

        /// <summary>
        /// Equipment type service instance
        /// </summary>
        private readonly EquipmentTypeService equipmentTypeService;

        /// <summary>
        /// Work types service instance
        /// </summary>
        private readonly WorkTypesService workTypesService;

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="equipmentTypeService"></param>
        public EquipmentController(EquipmentTypeService equipmentTypeService,
                                   WorkTypesService workTypesService)
        {
            this.equipmentTypeService = equipmentTypeService;
            this.workTypesService = workTypesService;
        }

        /// <summary>
        /// Return all equipment types
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<EquipmentTypeModel> GetTypes()
        {
            return equipmentTypeService.GetAll();
        }

        /// <summary>
        /// Return all available works types for an equipment type
        /// </summary>
        /// <param name="equipmentTypeId"></param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<WorkTypeModel> GetWorkFor(int equipmentTypeId)
        {
            return workTypesService.GetWorkTypesFor(equipmentTypeId);
        }
    }
}
