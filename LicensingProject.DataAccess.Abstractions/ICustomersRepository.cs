using LicensingProject.DataAccess.Models;

namespace LicensingProject.DataAccess.Abstractions
{
    public interface ICustomersRepository:IBaseRepository<Customer>
    {
        public IEnumerable<Customer> GetCustomersWithAssociatedLicenses();
        
    }
}