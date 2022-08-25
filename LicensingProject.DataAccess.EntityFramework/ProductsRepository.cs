using LicensingProject.DataAccess.Abstractions;
using LicensingProject.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensingProject.DataAccess.EntityFramework
{
    public class ProductsRepository: BaseRepository<Product>, IProductsRepository
    {
        public ProductsRepository(LicensingDbContext dbContext) : base(dbContext)
        { }
    }
}
