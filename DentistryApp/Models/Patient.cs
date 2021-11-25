using System.Collections.Generic;

namespace DentistryApp.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Coupon> Coupons { get; set; }
        public override string ToString()
        {
            return Name;
        }       
    }
}
