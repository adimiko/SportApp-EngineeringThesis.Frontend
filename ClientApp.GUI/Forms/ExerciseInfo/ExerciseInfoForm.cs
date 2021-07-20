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
    public partial class ExerciseInfoForm : Form
    {
        private readonly IExerciseInfoRestClient _exerciseInfoRestClient;
        public ExerciseInfoForm(IExerciseInfoRestClient exerciseInfoRestClient)
        {
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
            var ei = obj as ExerciseInfoModel;
            var eiDetails = await _exerciseInfoRestClient.GetAsync(ei.Id);
            MessageBox.Show(eiDetails.ToString());
        }

        private void ExerciseInfoForm_Load(object sender, EventArgs e)
            => RefreshExerciseInfoListBox();

        private async void RefreshExerciseInfoListBox()
        {
            var exerciseInfo = await _exerciseInfoRestClient.BrowseAsync();
            if (exerciseInfo == null) exerciseInfo = new List<ExerciseInfoModel>();
            ExerciseInfoListBox.Items.Clear();
            ExerciseInfoListBox.Items.AddRange(exerciseInfo.ToArray());
        }
    }
}
