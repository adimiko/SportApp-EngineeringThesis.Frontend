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

namespace ClientApp.GUI.Forms.Archive
{
    public partial class ArchiveForm : Form
    {
        private readonly ICustomWorkoutRoutineRestClient _customWorkoutRoutineRestClient;
        public ArchiveForm(ICustomWorkoutRoutineRestClient customWorkoutRoutineRestClient)
        {
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
            var customWorkoutRoutine = await _customWorkoutRoutineRestClient.BrowseArchiveAsync();
            if (customWorkoutRoutine == null) customWorkoutRoutine = new List<CustomWorkoutRoutine>();
            CustomWorkoutRoutineListBox.Items.Clear();
            CustomWorkoutRoutineListBox.Items.AddRange(customWorkoutRoutine.ToArray());
        }

        private void ArchiveForm_Load(object sender, EventArgs e)
            => RefreshCustomWorkoutRoutineListBox();

        private async void RestoreButton_Click(object sender, EventArgs e)
        {
            if (CustomWorkoutRoutineListBox.SelectedItem == null) return;
            var obj = CustomWorkoutRoutineListBox.SelectedItem;
            var swr = obj as CustomWorkoutRoutine;
            await _customWorkoutRoutineRestClient.RestoreAsync(swr.Id);
            RefreshCustomWorkoutRoutineListBox();
        }
    }
}
