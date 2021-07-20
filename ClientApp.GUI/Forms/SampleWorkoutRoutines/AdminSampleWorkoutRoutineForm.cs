using ClientApp.RestApiClient.Endpoints.V1.SampleWorkoutRoutines;
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


namespace ClientApp.GUI.Forms.SampleWorkoutRoutines
{
    public partial class AdminSampleWorkoutRoutineForm : Form
    {

        private readonly ISampleWorkoutRoutineRestClient _sampleWorkoutRoutineRestClient;
        private readonly SimpleInjector.Container _container;
        public AdminSampleWorkoutRoutineForm(SimpleInjector.Container container, ISampleWorkoutRoutineRestClient sampleWorkoutRoutineRestClient)
        {
            _container = container;
            _sampleWorkoutRoutineRestClient = sampleWorkoutRoutineRestClient;
            InitializeComponent();
            SampleWorkoutRoutineListBox.BackColor = this.BackColor;
            SampleWorkoutRoutineListBox.ForeColor = Color.White;
            SampleWorkoutRoutineListBox.BorderStyle = BorderStyle.None;
        }

        private async void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            if (SampleWorkoutRoutineListBox.SelectedItem == null) return;
            var obj = SampleWorkoutRoutineListBox.SelectedItem;
            var swr = obj as SampleWorkoutRoutine;
            var swrDetails = await _sampleWorkoutRoutineRestClient.GetAsync(swr.Id);
            MessageBox.Show(swrDetails.ToString());
        }

        private async void RefreshSampleWorkoutRoutineListBox()
        {
            var sampleWorkoutRoutine = await _sampleWorkoutRoutineRestClient.BrowseAsync();
            if (sampleWorkoutRoutine == null) sampleWorkoutRoutine = new List<SampleWorkoutRoutine>();
            SampleWorkoutRoutineListBox.Items.Clear();
            SampleWorkoutRoutineListBox.Items.AddRange(sampleWorkoutRoutine.ToArray());
        }

        private void AdminSampleWorkoutRoutineForm_Load(object sender, EventArgs e)
            => RefreshSampleWorkoutRoutineListBox();

        private async void ArchiveButton_Click(object sender, EventArgs e)
        {
            if (SampleWorkoutRoutineListBox.SelectedItem == null) return;
            var obj = SampleWorkoutRoutineListBox.SelectedItem;
            var swr = obj as SampleWorkoutRoutine;
            await _sampleWorkoutRoutineRestClient.ArchiveAsync(swr.Id);
            RefreshSampleWorkoutRoutineListBox();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            _container.GetInstance<CreateSampleWorkoutRoutineForm>().ShowDialog();
            RefreshSampleWorkoutRoutineListBox();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SampleWorkoutRoutineListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
