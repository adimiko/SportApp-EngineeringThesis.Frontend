using ClientApp.RestApiClient.Endpoints.V1.ExerciseInfo;
using ClientApp.RestApiClient.Endpoints.V1.SampleWorkoutRoutines;
using ClientApp.RestApiClient.Models.ExerciseInfo;
using ClientApp.RestApiClient.Models.SampleWorkoutRoutines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.GUI.Forms.Archive
{
    public partial class AdminArchiveForm : Form
    {
        private readonly IExerciseInfoRestClient _exerciseInfoRestClient;
        private readonly ISampleWorkoutRoutineRestClient _sampleWorkoutRoutineRestClient;

        public AdminArchiveForm(IExerciseInfoRestClient exerciseInfoRestClient, ISampleWorkoutRoutineRestClient sampleWorkoutRoutineRestClient)
        {
            _exerciseInfoRestClient = exerciseInfoRestClient;
            _sampleWorkoutRoutineRestClient = sampleWorkoutRoutineRestClient;

            InitializeComponent();
            ExerciseInfoListBox.BackColor = this.BackColor;
            ExerciseInfoListBox.ForeColor = Color.White;

            SampleWorkoutRoutineListBox.BackColor = this.BackColor;
            SampleWorkoutRoutineListBox.ForeColor = Color.White;
        }

        private async void RestoreExerciseInfoButton_Click(object sender, EventArgs e)
        {
            if (ExerciseInfoListBox.SelectedItem == null) return;
            var obj = ExerciseInfoListBox.SelectedItem;
            var ei = obj as ExerciseInfoModel;
            await _exerciseInfoRestClient.RestoreAsync(ei.Id);
            RefreshExerciseInfoListBox();
        }

        private async void RefreshExerciseInfoListBox()
        {
            var exerciseInfo = await _exerciseInfoRestClient.BrowseArchiveAsync();
            if (exerciseInfo == null) exerciseInfo = new List<ExerciseInfoModel>();
            ExerciseInfoListBox.Items.Clear();
            ExerciseInfoListBox.Items.AddRange(exerciseInfo.ToArray());
        }

        private async void RefreshSampleWorkoutRoutineListBox()
        {
            var sampleWorkoutRoutine = await _sampleWorkoutRoutineRestClient.BrowseArchiveAsync();
            if (sampleWorkoutRoutine == null) sampleWorkoutRoutine = new List<SampleWorkoutRoutine>();
            SampleWorkoutRoutineListBox.Items.Clear();
            SampleWorkoutRoutineListBox.Items.AddRange(sampleWorkoutRoutine.ToArray());
        }

        private void AdminArchiveForm_Load(object sender, EventArgs e)
        {
            RefreshExerciseInfoListBox();
            RefreshSampleWorkoutRoutineListBox();
        }

        private async void RestoreSampleWokroutRoutineButton_Click(object sender, EventArgs e)
        {
            if (SampleWorkoutRoutineListBox.SelectedItem == null) return;
            var obj = SampleWorkoutRoutineListBox.SelectedItem;
            var swr = obj as SampleWorkoutRoutine;
            await _sampleWorkoutRoutineRestClient.RestoreAsync(swr.Id);
            RefreshSampleWorkoutRoutineListBox();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExerciseInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void SampleWorkoutRoutineListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SampleWorkoutRoutinesLabel_Click(object sender, EventArgs e)
        {

        }

        private void ExerciseInfoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}