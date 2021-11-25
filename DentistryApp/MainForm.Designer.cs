
namespace DentistryApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAdminToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPatientToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.DoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDoctorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DiagnosisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDiagnosisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CouponsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СправкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.СправкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(71, 465);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(58, 19);
            this.файлToolStripMenuItem.Text = "Файл ";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminToolStripMenuItem,
            this.PatientsToolStripMenuItem,
            this.DoctorsToolStripMenuItem,
            this.DiagnosisToolStripMenuItem,
            this.CouponsToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(58, 19);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // AdminToolStripMenuItem
            // 
            this.AdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAdminToolStripMenuItem1});
            this.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem";
            this.AdminToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.AdminToolStripMenuItem.Text = "Администратор";
            this.AdminToolStripMenuItem.Click += new System.EventHandler(this.AdminToolStripMenuItem_Click);
            // 
            // AddAdminToolStripMenuItem1
            // 
            this.AddAdminToolStripMenuItem1.Name = "AddAdminToolStripMenuItem1";
            this.AddAdminToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.AddAdminToolStripMenuItem1.Text = "Добавить";
            this.AddAdminToolStripMenuItem1.Click += new System.EventHandler(this.AddAdminToolStripMenuItem1_Click);
            // 
            // PatientsToolStripMenuItem
            // 
            this.PatientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPatientToolStripMenuItem3});
            this.PatientsToolStripMenuItem.Name = "PatientsToolStripMenuItem";
            this.PatientsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.PatientsToolStripMenuItem.Text = "Пациенты";
            this.PatientsToolStripMenuItem.Click += new System.EventHandler(this.PatientsToolStripMenuItem_Click);
            // 
            // AddPatientToolStripMenuItem3
            // 
            this.AddPatientToolStripMenuItem3.Name = "AddPatientToolStripMenuItem3";
            this.AddPatientToolStripMenuItem3.Size = new System.Drawing.Size(126, 22);
            this.AddPatientToolStripMenuItem3.Text = "Добавить";
            this.AddPatientToolStripMenuItem3.Click += new System.EventHandler(this.AddPatientToolStripMenuItem3_Click);
            // 
            // DoctorsToolStripMenuItem
            // 
            this.DoctorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDoctorToolStripMenuItem2});
            this.DoctorsToolStripMenuItem.Name = "DoctorsToolStripMenuItem";
            this.DoctorsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.DoctorsToolStripMenuItem.Text = "Врачи";
            this.DoctorsToolStripMenuItem.Click += new System.EventHandler(this.DoctorsToolStripMenuItem_Click);
            // 
            // AddDoctorToolStripMenuItem2
            // 
            this.AddDoctorToolStripMenuItem2.Name = "AddDoctorToolStripMenuItem2";
            this.AddDoctorToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.AddDoctorToolStripMenuItem2.Text = "Добавить";
            this.AddDoctorToolStripMenuItem2.Click += new System.EventHandler(this.AddDoctorToolStripMenuItem2_Click);
            // 
            // DiagnosisToolStripMenuItem
            // 
            this.DiagnosisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDiagnosisToolStripMenuItem});
            this.DiagnosisToolStripMenuItem.Name = "DiagnosisToolStripMenuItem";
            this.DiagnosisToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.DiagnosisToolStripMenuItem.Text = "Диагноз";
            this.DiagnosisToolStripMenuItem.Click += new System.EventHandler(this.DiagnosisToolStripMenuItem_Click);
            // 
            // AddDiagnosisToolStripMenuItem
            // 
            this.AddDiagnosisToolStripMenuItem.Name = "AddDiagnosisToolStripMenuItem";
            this.AddDiagnosisToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.AddDiagnosisToolStripMenuItem.Text = "Добавить";
            this.AddDiagnosisToolStripMenuItem.Click += new System.EventHandler(this.AddDiagnosisToolStripMenuItem_Click);
            // 
            // CouponsToolStripMenuItem
            // 
            this.CouponsToolStripMenuItem.Name = "CouponsToolStripMenuItem";
            this.CouponsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.CouponsToolStripMenuItem.Text = "Талоны";
            this.CouponsToolStripMenuItem.Click += new System.EventHandler(this.CouponsToolStripMenuItem_Click);
            // 
            // СправкаToolStripMenuItem
            // 
            this.СправкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem";
            this.СправкаToolStripMenuItem.Size = new System.Drawing.Size(58, 19);
            this.СправкаToolStripMenuItem.Text = "Справка";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DentistryApp.Properties.Resources._5_20;
            this.pictureBox1.Location = new System.Drawing.Point(74, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(733, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 532);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стоматология";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DiagnosisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СправкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CouponsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddDiagnosisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddAdminToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AddDoctorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem AddPatientToolStripMenuItem3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

