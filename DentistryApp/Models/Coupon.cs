using System;
using System.Collections.Generic;

namespace DentistryApp.Models
{
    public class Coupon
    {
        public int CouponId { get; set; }
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public int AdministratorId { get; set; } 
        public virtual Administrator Administrator { get; set; }
        public DateTime Created { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
        public override string ToString()
        {
            return $"№{CouponId} от {Created:dd.MM.yy hh:mm:ss}";
        }
    }
}
