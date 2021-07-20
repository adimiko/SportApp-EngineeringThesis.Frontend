using ClientApp.RestApiClient.Endpoints.V1.CustomWorkoutRoutines;
using ClientApp.RestApiClient.Endpoints.V1.SampleWorkoutRoutines;
using ClientApp.RestApiClient.Models.CustomWorkoutRoutines;
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

namespace ClientApp.GUI.Forms.StartWorkout
{
    public partial class StartWorkoutForm : Form
    {
        private readonly ISampleWorkoutRoutineRestClient _sampleWorkoutRoutineRestClient;
        private readonly ICustomWorkoutRoutineRestClient _customWorkoutRoutineRestClient;
        private readonly SimpleInjector.Container _container;
        public StartWorkoutForm(SimpleInjector.Container container,ISampleWorkoutRoutineRestClient sampleWorkoutRoutineRestClient, ICustomWorkoutRoutineRestClient customWorkoutRoutineRestClient)
        {
            _container = container;
            _sampleWorkoutRoutineRestClient = sampleWorkoutRoutineRestClient;
            _customWorkoutRoutineRestClient = customWorkoutRoutineRestClient;

            InitializeComponent();
            CustomWorkoutRoutineListBox.BackColor = this.BackColor;
            CustomWorkoutRoutineListBox.ForeColor = Color.White;

            SampleWorkoutRoutineListBox.BackColor = this.BackColor;
            SampleWorkoutRoutineListBox.ForeColor = Color.White;
        }

        private async void RefreshListBox()
        {
            var sampleWorkoutRoutine = await _sampleWorkoutRoutineRestClient.BrowseAsync();
            if (sampleWorkoutRoutine == null) sampleWorkoutRoutine = new List<SampleWorkoutRoutine>();
            SampleWorkoutRoutineListBox.Items.Clear();
            SampleWorkoutRoutineListBox.Items.AddRange(sampleWorkoutRoutine.ToArray());

            var customWorkoutRoutine = await _customWorkoutRoutineRestClient.BrowseAsync();
            if (customWorkoutRoutine == null) customWorkoutRoutine = new List<CustomWorkoutRoutine>();
            CustomWorkoutRoutineListBox.Items.Clear();
            CustomWorkoutRoutineListBox.Items.AddRange(customWorkoutRoutine.ToArray());
        }

        private async void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            if (SampleWorkoutRoutineListBox.SelectedItem == null && CustomWorkoutRoutineListBox.SelectedItem == null) return;

            if (SampleWorkoutRoutineListBox.SelectedItem != null)
            {
                var obj = SampleWorkoutRoutineListBox.SelectedItem;
                var swr = obj as SampleWorkoutRoutine;
                var swrDetails = await _sampleWorkoutRoutineRestClient.GetAsync(swr.Id);
                MessageBox.Show(swrDetails.ToString());
            }

            if (CustomWorkoutRoutineListBox.SelectedItem != null)
            {
                var obj = CustomWorkoutRoutineListBox.SelectedItem;
                var cwr = obj as CustomWorkoutRoutine;
                var cwrDetails = await _customWorkoutRoutineRestClient.GetAsync(cwr.Id);
                MessageBox.Show(cwrDetails.ToString());
            }
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            
            if (SampleWorkoutRoutineListBox.SelectedItem == null && CustomWorkoutRoutineListBox.SelectedItem == null) return;

            if(SampleWorkoutRoutineListBox.SelectedItem != null)
            {
                var obj = SampleWorkoutRoutineListBox.SelectedItem;
                var wr = obj as SampleWorkoutRoutine;

                var wrDetails = await _sampleWorkoutRoutineRestClient.GetAsync(wr.Id);

                var form = _container.GetInstance<WorkoutForm>();

                form.workoutRoutine = wrDetails;
                form.ShowDialog();
            }

            if(CustomWorkoutRoutineListBox.SelectedItem != null)
            {
                var obj = CustomWorkoutRoutineListBox.SelectedItem;
                var wr = obj as CustomWorkoutRoutine;

                var wrDetails = await _customWorkoutRoutineRestClient.GetAsync(wr.Id);
                var form = _container.GetInstance<WorkoutForm>();

                form.workoutRoutine = wrDetails;
                form.ShowDialog();
            }

        }

        private void StartWorkoutForm_Load(object sender, EventArgs e)
            => RefreshListBox();

        private void CustomWorkoutRoutineListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomWorkoutRoutineListBox.SelectedIndex == -1) return;
            SampleWorkoutRoutineListBox.ClearSelected();
        }


        private void SampleWorkoutRoutineListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SampleWorkoutRoutineListBox.SelectedIndex == -1) return;
            CustomWorkoutRoutineListBox.ClearSelected();
        }

    }
}
