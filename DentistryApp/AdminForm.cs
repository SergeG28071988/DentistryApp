using DentistryApp.Models;
using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace DentistryApp
{
    public partial class AdminForm : MetroForm
    {
        public Administrator Administrator { get; set; }
        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminForm(Administrator administrator) : this()
        {
            Administrator = administrator ?? new Administrator();
            textBox1.Text = Administrator.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administrator = Administrator ?? new Administrator();
            Administrator.Name = textBox1.Text;
            Close();
        }
    }
}
