namespace Ginkoya.MaintenanceManager.Core.Models
{
    /// <summary>
    /// Model for View management
    /// </summary>
    public class WorkTypeModel
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
        /// Some works can have fixed price
        /// <para>
        /// IF TRUE : Price and duration should not be computed
        /// </para>
        /// <para>
        /// IF False : Do not use Duration, Price should be computed with duration given by user
        /// </para>
        /// </summary>
        public bool HaveFixedPrice { get; set; }

        /// <summary>
        /// Price
        /// <para>
        /// IF TRUE : Price and duration should not be computed
        /// </para>
        /// <para>
        /// IF FALSE : Price is price per minutes
        /// </para>
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Duration for fixed price
        /// </summary>
        public int FixedDuration { get; set; }
    }
}
