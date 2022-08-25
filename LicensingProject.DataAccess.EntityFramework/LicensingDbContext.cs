using LicensingProject.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensingProject.DataAccess.EntityFramework
{
    public class LicensingDbContext: DbContext
    {
        public LicensingDbContext(DbContextOptions<LicensingDbContext> options): base(options)
        { 
        }
        DbSet<Customer> Customers { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<License> Licenses { get; set; }
        DbSet<LicensedProduct> LicensedProducts { get; set; }


    }
}
