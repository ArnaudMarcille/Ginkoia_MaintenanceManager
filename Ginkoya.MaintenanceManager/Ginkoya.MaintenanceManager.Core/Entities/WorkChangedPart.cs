namespace Ginkoya.MaintenanceManager.Core.Entities
{
    /// <summary>
    /// Work changed parts
    /// <para>
    /// Define the changed part of a work
    /// </para>
    /// </summary>
    public class WorkChangedPart
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
        /// Price
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Product id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Work id
        /// </summary>
        public int WorkId { get; set; }

        #region Navigation Properties

        /// <summary>
        /// Target work
        /// </summary>
        public Work Work { get; set; }

        /// <summary>
        /// Original product (<see cref="WorkChangedPart.Price"/> and <see cref="CatalogProduct.Price"/> can be different if catalog product have changed)
        /// </summary>
        public CatalogProduct Product { get; set; }

        #endregion
    }
}
