namespace Ginkoya.MaintenanceManager.Core.Entities
{
    /// <summary>
    /// Equipement
    /// </summary>
    public class Equipment
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Serial number
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// TypeId
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// Customer Id
        /// </summary>
        public int CustomerId { get; set; }

        #region Navigation Properties

        /// <summary>
        /// Equipment's customer
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Work done on equipment
        /// </summary>
        public List<Work> Works { get; set; }

        /// <summary>
        /// Equipment type
        /// </summary>
        public EquipmentType Type { get; set; }

        #endregion
    }
}
