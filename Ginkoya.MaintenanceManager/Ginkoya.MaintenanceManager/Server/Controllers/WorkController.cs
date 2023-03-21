using Ginkoya.MaintenanceManager.Core.Models;
using Ginkoya.MaintenanceManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ginkoya.MaintenanceManager.Server.Controllers
{
    /// <summary>
    /// Work controller
    /// </summary>
    [ApiController]
    [Route("[controller]/[action]")]
    public class WorkController : Controller
    {
        #region Fields

        private readonly WorkHelper workHelper;

        #endregion

        public WorkController(WorkHelper workHelper)
        {
            this.workHelper = workHelper;
        }

        [HttpPost]
        public void Create([FromBody] NewWorkModel newWorkModel)
        {
            if (newWorkModel is null)
            {
                return;
            }

            workHelper.SaveWork(newWorkModel);
        }
    }
}
