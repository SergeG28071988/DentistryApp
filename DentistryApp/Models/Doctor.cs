using System.Collections.Generic;

namespace DentistryApp.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }   
        public virtual ICollection<Patient> Patients { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
