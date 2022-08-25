namespace LicensingProject.DataAccess.Models
{
    public class Customer: BaseEntity
    {
        public string Name { get; set; } = "";
        public string? Address { get; set; }
        public string Phone { get; set; } = "";
        public ICollection<LicensedProduct>? LicensedProducts { get; set; }

    }
}