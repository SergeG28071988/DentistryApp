using DentistryApp.Models;
using System.Data.Entity;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace DentistryApp
{
    public partial class CatalogForm<T> : MetroForm
        where T : class
    {
        AppDbContext db;
        DbSet<T> set;
        public CatalogForm(DbSet<T> set, AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
            this.set = set;
            set.Load();
            dataGridView.DataSource = set.Local.ToBindingList();
        }
        /// <summary>
        /// Изменение данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeBtn_Click(object sender, System.EventArgs e) // кнопка изменения данных
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;
            if (typeof(T) == typeof(Diagnosis))
            {
                var diagnosis = set.Find(id) as Diagnosis;
                if (diagnosis != null)
                {
                    var form = new DiagnosisForm(diagnosis);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        diagnosis = form.Diagnosis;
                        db.SaveChanges();
                        dataGridView.Update();
                    }
                }
            }
            else if (typeof(T) == typeof(Patient))
            {
                var patient = set.Find(id) as Patient;
                if (patient != null)
                {
                    var form = new PatientForm(patient);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        patient = form.Patient;
                        db.SaveChanges();
                        dataGridView.Update();
                    }
                }
            }

            else if (typeof(T) == typeof(Doctor))
            {
                var doctor = set.Find(id) as Doctor;
                if (doctor != null)
                {
                    var form = new DoctorForm(doctor);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        doctor = form.Doctor;
                        db.SaveChanges();
                        dataGridView.Update();
                    }
                }
            }

            else if (typeof(T) == typeof(Administrator))
            {
                var administrator = set.Find(id) as Administrator;
                if (administrator != null)
                {
                    var form = new AdminForm(administrator);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        administrator = form.Administrator;
                        db.SaveChanges();
                        dataGridView.Update();
                    }
                }
            }
        }

        /// <summary>
        /// Возврат в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, System.EventArgs e) // кнопка возврата в главное меню
        {
            MainForm form = new MainForm();
            form.Show();
            Hide();
        }

        /// <summary>
        /// Добавление данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_Click(object sender, System.EventArgs e) // кнопка добавления данных. Функционал кнопки может быть реализован в будущем
                                                                     // при расширении функционала программы
        {
        }
    }
}
