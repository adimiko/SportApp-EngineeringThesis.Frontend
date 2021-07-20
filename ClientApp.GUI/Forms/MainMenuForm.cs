using ClientApp.GUI.Forms.Archive;
using ClientApp.GUI.Forms.CustomWorkoutRoutines;
using ClientApp.GUI.Forms.ExerciseInfo;
using ClientApp.GUI.Forms.Settings;
using ClientApp.GUI.Forms.StartWorkout;
using ClientApp.GUI.Forms.WorkoutsHistory;
using ClientApp.GUI.Forms.WorkoutStats;
using ClientApp.GUI.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.GUI.Forms
{
    public partial class MainMenuForm : Form
    {
        private readonly SimpleInjector.Container _container;
        public MainMenuForm(SimpleInjector.Container container)
        {
            _container = container;
            InitializeComponent();

        }

        private void ClipboardButton_Click(object sender, EventArgs e)
        {
            throw new Exception("Invalid");
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is CustomTextBox)
                {
                    ((CustomTextBox)c).BackColor = this.BackColor;
                }
            }
          
            openSubFormInContentPanel(_container.GetInstance<WorkoutsStatsForm>());
        }

        private void WorkoutsStatsButton_Click(object sender, EventArgs e)
            => openSubFormInContentPanel(_container.GetInstance<WorkoutsStatsForm>());

        private void BodyMeasurementButton_Click(object sender, EventArgs e)
            => openSubFormInContentPanel(_container.GetInstance<BodyMeasurementForm>());

        private void ExerciseInfoButton_Click(object sender, EventArgs e)
            => openSubFormInContentPanel(_container.GetInstance<ExerciseInfoForm>());

        private void CloseButton_Click(object sender, EventArgs e)
            => this.Close();

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

        private void CustomWorkoutRoutineButton_Click(object sender, EventArgs e)
            => openSubFormInContentPanel(_container.GetInstance<CustomWorkoutRoutineForm>());

        private void ArchiveButton_Click(object sender, EventArgs e)
            => openSubFormInContentPanel(_container.GetInstance<ArchiveForm>());

        private void StartWorkoutButton_Click(object sender, EventArgs e)
            => openSubFormInContentPanel(_container.GetInstance<StartWorkoutForm>());

        private void WorkoutsHistoryButton_Click(object sender, EventArgs e)
            => openSubFormInContentPanel(_container.GetInstance<WorkoutsHistoryForm>());

        private void SettingsButton_Click(object sender, EventArgs e)
            => openSubFormInContentPanel(_container.GetInstance<SettingsForm>());
    }
}
