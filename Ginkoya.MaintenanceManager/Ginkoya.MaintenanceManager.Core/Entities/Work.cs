namespace Ginkoya.MaintenanceManager.Core.Entities
{
    /// <summary>
    /// Work
    /// </summary>
    public class Work
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Label of the work
        /// </summary>
        public string Label { get; set; }

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
        /// Equipement Id
        /// </summary>
        public int EquipmentId { get; set; }

        /// <summary>
        /// WorkType Id
        /// </summary>
        public int WorkTypeId { get; set; }

        #region Navigation Properties

        /// <summary>
        /// Equipment attached to this work
        /// </summary>
        public Equipment Equipment { get; set; }

        /// <summary>
        /// Work type
        /// </summary>
        public WorkType WorkType { get; set; }

        /// <summary>
        /// Changed parts, can be empty
        /// </summary>
        public List<WorkChangedPart> WorkChangedParts { get; set; }

        #endregion
    }
}
