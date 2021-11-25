using DentistryApp.Models;
using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace DentistryApp
{
    public partial class MainForm : MaterialForm
    {
        private readonly AppDbContext db;
        public MainForm()
        {
            InitializeComponent();
            db = new AppDbContext();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void DiagnosisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogDiagnosis = new CatalogForm<Diagnosis>(db.Diagnoses, db);
            catalogDiagnosis.Show();
            Hide();
        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogAdministrator = new CatalogForm<Administrator>(db.Administrators, db);
            catalogAdministrator.Show();
            Hide();
        }

        private void DoctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogDoctors = new CatalogForm<Doctor>(db.Doctors, db);
            catalogDoctors.Show();
            Hide();
        }

        private void PatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogPatient = new CatalogForm<Patient>(db.Patients, db);
            catalogPatient.Show();
            Hide();
        }

        private void CouponsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCoupon = new CatalogForm<Coupon>(db.Coupons, db);
            catalogCoupon.Show();
            Hide();
        }

        private void AddAdminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new AdminForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                db.Administrators.Add(form.Administrator);
                db.SaveChanges();
            }
        }

        private void AddPatientToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var form = new PatientForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Patients.Add(form.Patient);
                db.SaveChanges();
            }
        }

        private void AddDoctorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new DoctorForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Doctors.Add(form.Doctor);
                db.SaveChanges();
            }
        }

        private void AddDiagnosisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DiagnosisForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Diagnoses.Add(form.Diagnosis);
                db.SaveChanges();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор программы Стоматология: Андрей Федин., \nДата релиза: 18.11.2021 г.", "Внимание!!");
        }
    }
}
