using ClientApp.RestApiClient.Endpoints.V1.ExerciseInfo;
using ClientApp.RestApiClient.Models.ExerciseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.GUI.Forms.ExerciseInfo
{
    public partial class AdminExerciseInfoForm : Form
    {
        private readonly IExerciseInfoRestClient _exerciseInfoRestClient;
        private readonly SimpleInjector.Container _container;
        public AdminExerciseInfoForm(SimpleInjector.Container container, IExerciseInfoRestClient exerciseInfoRestClient)
        {
            _container = container;
            _exerciseInfoRestClient = exerciseInfoRestClient;

            InitializeComponent();
            ExerciseInfoListBox.BackColor = this.BackColor;
            ExerciseInfoListBox.ForeColor = Color.White;
            ExerciseInfoListBox.BorderStyle = BorderStyle.None;
        }

        private async void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            if (ExerciseInfoListBox.SelectedItem == null) return;
            var obj = ExerciseInfoListBox.SelectedItem;
            var bm = obj as ExerciseInfoModel;
            var bmDetails = await _exerciseInfoRestClient.GetAsync(bm.Id);
            MessageBox.Show(bmDetails.ToString());
        }

        private async void RefreshExerciseInfoListBox()
        {
            var exerciseInfo = await _exerciseInfoRestClient.BrowseAsync();
            if (exerciseInfo == null) exerciseInfo = new List<ExerciseInfoModel>();
            ExerciseInfoListBox.Items.Clear();
            ExerciseInfoListBox.Items.AddRange(exerciseInfo.ToArray());
        }

        private void AdminExerciseInfoForm_Load(object sender, EventArgs e)
            => RefreshExerciseInfoListBox();

        private async void ArchiveButton_Click(object sender, EventArgs e)
        {
            if (ExerciseInfoListBox.SelectedItem == null) return;
            var obj = ExerciseInfoListBox.SelectedItem;
            var ei = obj as ExerciseInfoModel;
            await _exerciseInfoRestClient.ArchiveAsync(ei.Id);
            RefreshExerciseInfoListBox();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            _container.GetInstance<CreateExerciseInfoForm>().ShowDialog();
            RefreshExerciseInfoListBox();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            if (ExerciseInfoListBox.SelectedItem == null) return;
            var obj = ExerciseInfoListBox.SelectedItem;
            var bm = obj as ExerciseInfoModel;

            var updateForm = _container.GetInstance<UpdateExerciseInfoForm>();
            updateForm.Id = bm.Id;
            updateForm.ShowDialog();

            RefreshExerciseInfoListBox();
        }
    }
}
