using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensingProject.DataAccess.Models
{
    public class LicensedProduct: BaseEntity
    {
        public ICollection<License> Licenses { get; set; }    
        public Product? Product { get; set; }
    }
}
