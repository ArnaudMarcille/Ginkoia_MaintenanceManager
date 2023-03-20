namespace Ginkoya.MaintenanceManager.Core.Entities
{
    /// <summary>
    /// Catalog products
    /// </summary>
    public class CatalogProduct
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product label
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Product price
        /// </summary>
        public int Price { get; set; }

    }
}
