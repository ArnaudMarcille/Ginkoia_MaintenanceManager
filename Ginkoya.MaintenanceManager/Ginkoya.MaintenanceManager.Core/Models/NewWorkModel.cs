namespace Ginkoya.MaintenanceManager.Core.Models
{
    /// <summary>
    /// Model for new work creation
    /// </summary>
    public class NewWorkModel
    {
        #region Customer datas

        /// <summary>
        /// Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Mail
        /// </summary>
        public string Mail { get; set; }

        #endregion

        #region Equipment datas

        /// <summary>
        /// Label
        /// </summary>
        public string EquipmentLabel { get; set; }

        /// <summary>
        /// Serial number
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// TypeId
        /// </summary>
        public int TypeId { get; set; }

        #endregion

        #region Work data

        /// <summary>
        /// Label of the work
        /// </summary>
        public string WorkLabel { get; set; }

        /// <summary>
        /// Date of the work
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Technician attached to the work
        /// </summary>
        public string Technician { get; set; }

        /// <summary>
        /// Duration
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Final price
        /// </summary>
        public int FinalPrice { get; set; }

        /// <summary>
        /// Work type
        /// </summary>
        public int WorkTypeId { get; set; }

        /// <summary>
        /// Changed parts
        /// </summary>
        List<ChangedPartModel> ChangedParts { get; set; } = new List<ChangedPartModel>();

        #endregion

    }
}
