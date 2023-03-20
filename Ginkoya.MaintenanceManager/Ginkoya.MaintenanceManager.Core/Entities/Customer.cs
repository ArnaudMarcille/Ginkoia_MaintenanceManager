namespace Ginkoya.MaintenanceManager.Core.Entities
{
    /// <summary>
    /// Customer
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public int Id { get; set; }

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

        #region Navigation Properties

        /// <summary>
        /// Customer's equipments
        /// </summary>
        public List<Equipment> Equipments { get; set; }

        #endregion

    }
}
