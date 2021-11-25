using System;

namespace DentistryApp.Models
{
    public class Visit
    {
        public int VisitId { get; set; }
        public int CouponId { get; set; }
        public int DiagnosisId { get; set; }
        public virtual Coupon Coupon { get; set; }
        public virtual Diagnosis Diagnosis { get; set; }
    }
}
