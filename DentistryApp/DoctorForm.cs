using System;
using System.Windows.Forms;
using DentistryApp.Models;
using MetroFramework.Forms;

namespace DentistryApp
{
    public partial class DoctorForm : MetroForm
    {
        public Doctor Doctor { get; set; }
        public DoctorForm()
        {
            InitializeComponent();
        }

        public DoctorForm(Doctor doctor) : this()
        {
            Doctor = doctor ?? new Doctor();
            textBox1.Text = Doctor.Name;
            textBox2.Text = Doctor.Speciality;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Doctor = Doctor ?? new Doctor();
            Doctor.Name = textBox1.Text;
            Doctor.Speciality = textBox2.Text;
            Close();
        }
    }
}
