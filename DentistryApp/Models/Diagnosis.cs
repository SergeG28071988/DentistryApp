using System.Collections.Generic;

namespace DentistryApp.Models
{
    public class Diagnosis
    {
        public int DiagnosisId { get; set; }        
        public string Name { get; set; }
        public string Description { get; set; }
        public string Treatment { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }       
        public decimal Price { get; set; }
        public override string ToString()
        {
            return Name;
        }        
    }
}
