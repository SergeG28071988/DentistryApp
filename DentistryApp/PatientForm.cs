using DentistryApp.Models;
using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace DentistryApp
{
    public partial class PatientForm : MetroForm
    {
        public Patient Patient { get; set; }
        public PatientForm()
        {
            InitializeComponent();
        }

        public PatientForm(Patient patient) : this()
        {
            Patient = patient ?? new Patient();
            textBox1.Text = Patient.Name;
            textBox2.Text = Patient.Address;
            textBox3.Text = Patient.Phone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient = Patient ?? new Patient();
            Patient.Name = textBox1.Text;
            Patient.Address = textBox2.Text;
            Patient.Phone = textBox3.Text;
            Close();
        }
    }
}
