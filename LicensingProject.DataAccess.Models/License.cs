using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensingProject.DataAccess.Models
{
    public class License: BaseEntity
    {
        public string? Info { get; set; } 
        public string LicenseType { get; set; } = "";
        public DateTime StartDate { get; set; }
        public int NumberOfDays { get; set; }
        public bool IsTrial { get; set; }
    }
}
