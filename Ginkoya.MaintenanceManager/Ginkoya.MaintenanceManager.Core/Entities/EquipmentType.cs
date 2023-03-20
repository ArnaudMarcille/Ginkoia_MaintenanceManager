namespace Ginkoya.MaintenanceManager.Core.Entities
{
    /// <summary>
    /// Equipement type
    /// <para>
    /// Ex : Ski, Bike
    /// </para>
    /// </summary>
    public class EquipmentType
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        public string Label { get; set; }

        #region Navigation Properties

        /// <summary>
        /// Work types who can be done for this equipement type
        /// </summary>
        public List<WorkType> WorkTypes { get; set; }

        /// <summary>
        /// Equipments using this type
        /// </summary>
        public List<Equipment> Equipments { get; set; }

        #endregion

    }
}
