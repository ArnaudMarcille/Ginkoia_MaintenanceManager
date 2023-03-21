using Ginkoya.MaintenanceManager.Core.Entities;
using Ginkoya.MaintenanceManager.Data;

namespace Ginkoya.MaintenanceManager.Services
{
    public class CustomerService : BaseDBService
    {
        public CustomerService(IDBContextFactory factory) : base(factory)
        {
        }

        public int Create(string lastName, string name, string phone, string mail)
        {
            Customer customer = new Customer()
            {
                LastName = lastName,
                FirstName = name,
                Phone = phone,
                Mail = mail
            };

            DbContext.Add(customer);
            DbContext.SaveChanges();

            return customer.Id;
        }
    }
}
