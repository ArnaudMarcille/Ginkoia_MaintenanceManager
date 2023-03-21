namespace Ginkoya.MaintenanceManager.Core.Models
{
    /// <summary>
    /// Work List item model
    /// </summary>
    public class WorkListItemModel
    {
        /// <summary>
        /// User name
        /// </summary>
        public string CustomerFullName { get; set; }

        /// <summary>
        /// Technician name
        /// </summary>
        public string TechnicianName { get; set; }

        /// <summary>
        /// Customer equipment type label 
        /// </summary>
        public string EquipmentTypeLabel { get; set; }

        /// <summary>
        /// Equipment label
        /// </summary>
        public string EquipmentLabel { get; set; }

        /// <summary>
        /// Work label
        /// </summary>
        public string WorkLabel { get; set; }

        /// <summary>
        /// Work type label
        /// </summary>
        public string WorkTypeLabel { get; set; }

        /// <summary>
        /// Duration
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        public int Price { get; set; }
    }
}
