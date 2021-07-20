using ClientApp.RestApiClient.Endpoints.V1.CompletedWorkouts;
using ClientApp.RestApiClient.Models.CompletedWorkouts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.GUI.Forms.WorkoutsHistory
{
    public partial class WorkoutsHistoryForm : Form
    {
        private readonly ICompletedWorkoutRestClient _completedWorkoutRestClient;
        public WorkoutsHistoryForm(ICompletedWorkoutRestClient completedWorkoutRestClient)
        {
            _completedWorkoutRestClient = completedWorkoutRestClient;
            InitializeComponent();
            CompletedWorkoutsListBox.BackColor = this.BackColor;
            CompletedWorkoutsListBox.ForeColor = Color.White;
            CompletedWorkoutsListBox.BorderStyle = BorderStyle.None;
        }

        private async void RefreshCompletedWorkoutListBox()
        {
            var completedWorkout = await _completedWorkoutRestClient.BrowseAsync();
            if (completedWorkout == null) completedWorkout = new List<CompletedWorkout>();
            CompletedWorkoutsListBox.Items.Clear();
            CompletedWorkoutsListBox.Items.AddRange(completedWorkout.ToArray());
        }

        private async void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            if (CompletedWorkoutsListBox.SelectedItem == null) return;
            var obj = CompletedWorkoutsListBox.SelectedItem;
            var swr = obj as CompletedWorkout;
            var swrDetails = await _completedWorkoutRestClient.GetAsync(swr.Id);
            MessageBox.Show(swrDetails.ToString());
        }

        private void WorkoutsHistoryForm_Load(object sender, EventArgs e)
            => RefreshCompletedWorkoutListBox();

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (CompletedWorkoutsListBox.SelectedItem == null) return;
            var obj = CompletedWorkoutsListBox.SelectedItem;
            var swr = obj as CompletedWorkout;
            await _completedWorkoutRestClient.DeleteAsync(swr.Id);
            RefreshCompletedWorkoutListBox();
        }
    }
}
