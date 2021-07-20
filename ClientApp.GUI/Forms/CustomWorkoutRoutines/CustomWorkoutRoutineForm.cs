using ClientApp.RestApiClient.Endpoints.V1.CustomWorkoutRoutines;
using ClientApp.RestApiClient.Models.CustomWorkoutRoutines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.GUI.Forms.CustomWorkoutRoutines
{
    public partial class CustomWorkoutRoutineForm : Form
    {
        private readonly ICustomWorkoutRoutineRestClient _customWorkoutRoutineRestClient;
        private readonly SimpleInjector.Container _container;
        public CustomWorkoutRoutineForm(SimpleInjector.Container container, ICustomWorkoutRoutineRestClient customWorkoutRoutineRestClient)
        {
            _container = container;
            _customWorkoutRoutineRestClient = customWorkoutRoutineRestClient;
            InitializeComponent();
            CustomWorkoutRoutineListBox.BackColor = this.BackColor;
            CustomWorkoutRoutineListBox.ForeColor = Color.White;
            CustomWorkoutRoutineListBox.BorderStyle = BorderStyle.None;
        }

        private async void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            if (CustomWorkoutRoutineListBox.SelectedItem == null) return;
            var obj = CustomWorkoutRoutineListBox.SelectedItem;
            var swr = obj as CustomWorkoutRoutine;
            var swrDetails = await _customWorkoutRoutineRestClient.GetAsync(swr.Id);
            MessageBox.Show(swrDetails.ToString());
        }

        private async void RefreshCustomWorkoutRoutineListBox()
        {
            var customWorkoutRoutine = await _customWorkoutRoutineRestClient.BrowseAsync();
            if (customWorkoutRoutine == null) customWorkoutRoutine = new List<CustomWorkoutRoutine>();
            CustomWorkoutRoutineListBox.Items.Clear();
            CustomWorkoutRoutineListBox.Items.AddRange(customWorkoutRoutine.ToArray());
        }

        private async void ArchiveButton_Click(object sender, EventArgs e)
        {
            if (CustomWorkoutRoutineListBox.SelectedItem == null) return;
            var obj = CustomWorkoutRoutineListBox.SelectedItem;
            var swr = obj as CustomWorkoutRoutine;
            await _customWorkoutRoutineRestClient.ArchiveAsync(swr.Id);
            RefreshCustomWorkoutRoutineListBox();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            _container.GetInstance<CreateCustomWorkoutRoutineForm>().ShowDialog();
            RefreshCustomWorkoutRoutineListBox();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomWorkoutRoutineListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomWorkoutRoutineForm_Load(object sender, EventArgs e)
            => RefreshCustomWorkoutRoutineListBox();
    }
}
