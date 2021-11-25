using System;
using DentistryApp.Models;
using MetroFramework.Forms;

namespace DentistryApp
{
    public partial class DiagnosisForm : MetroForm
    {
        public Diagnosis Diagnosis { get; set; }
        public DiagnosisForm()
        {
            InitializeComponent();
        }

        public DiagnosisForm(Diagnosis diagnosis) : this()
        {
            Diagnosis = diagnosis ?? new Diagnosis();
            textBox1.Text = Diagnosis.Name;
            textBox2.Text = Diagnosis.Description;
            textBox3.Text = Diagnosis.Treatment;
            numericUpDown1.Value = Diagnosis.Price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diagnosis = Diagnosis ?? new Diagnosis();
            Diagnosis.Name = textBox1.Text;
            Diagnosis.Description = textBox2.Text;
            Diagnosis.Treatment = textBox3.Text;
            Diagnosis.Price = numericUpDown1.Value;
            Close();
        }
    }
}
