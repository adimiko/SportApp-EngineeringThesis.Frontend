using ClientApp.GUI.Forms.Archive;
using ClientApp.GUI.Forms.ExerciseInfo;
using ClientApp.GUI.Forms.SampleWorkoutRoutines;
using ClientApp.GUI.Forms.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.GUI.Forms
{
    public partial class AdminMainMenuForm : Form
    {
        private readonly SimpleInjector.Container _container;
        public AdminMainMenuForm(SimpleInjector.Container container)
        {
            _container = container;
            InitializeComponent();
        }

        private void ExerciseInfoButton_Click(object sender, EventArgs e)
             => openSubFormInContentPanel(_container.GetInstance<AdminExerciseInfoForm>());

        private void SampleWorkoutRoutineButton_Click(object sender, EventArgs e)
             => openSubFormInContentPanel(_container.GetInstance<AdminSampleWorkoutRoutineForm>());

        private Form currentSubForm = null;
        private void openSubFormInContentPanel(Form subForm)
        {
            if (currentSubForm != null) currentSubForm.Close();

            currentSubForm = subForm;

            currentSubForm.BackColor = ContentPanel.BackColor;
            currentSubForm.TopLevel = false;

            currentSubForm.Width = ContentPanel.Width;
            currentSubForm.Dock = DockStyle.Fill;

            currentSubForm.AutoScroll = true;


            ContentPanel.Controls.Add(currentSubForm);
            currentSubForm.Show();
        }

        private void ArchiveButton_Click(object sender, EventArgs e)
             => openSubFormInContentPanel(_container.GetInstance<AdminArchiveForm>());

        private void CloseButton_Click(object sender, EventArgs e)
            => this.Close();

        private void SettingsButton_Click(object sender, EventArgs e)
             => openSubFormInContentPanel(_container.GetInstance<AdminSettingsForm>());

        private void AdminMainMenuForm_Load(object sender, EventArgs e)
             => openSubFormInContentPanel(_container.GetInstance<AdminSampleWorkoutRoutineForm>());
    }
}
