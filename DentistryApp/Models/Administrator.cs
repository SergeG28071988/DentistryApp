using System.Collections.Generic;

namespace DentistryApp.Models
{
    public class Administrator
    {
        public int AdministratorId { get; set; } 
        public string Name { get; set; }
        public virtual ICollection<Coupon> Coupons { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
