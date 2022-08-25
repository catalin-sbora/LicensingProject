using LicensingProject.DataAccess.Abstractions;
using LicensingProject.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace LicensingProject.DataAccess.EntityFramework
{
    public class CustomerRepository: BaseRepository<Customer>, ICustomersRepository
    {
        public CustomerRepository(LicensingDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<Customer> GetCustomersWithAssociatedLicenses()
        {
            return dbContext
                 .Set<Customer>()
                 .Include(c => c.LicensedProducts).ThenInclude(lp => lp.Product) 
                 .Include(c => c.LicensedProducts).ThenInclude(lp => lp.Licenses)
                 .ToList();
        }
    }
}