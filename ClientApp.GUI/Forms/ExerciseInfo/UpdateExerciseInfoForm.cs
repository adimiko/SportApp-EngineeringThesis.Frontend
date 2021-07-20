using ClientApp.GUI.Extensions;
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
    public partial class UpdateExerciseInfoForm : Form
    {
        public Guid Id { get; set; }
        private readonly IExerciseInfoRestClient _exerciseInfoRestClient;
        private readonly IMessenger _messenger;
        private UpdateExerciseInfo updateExerciseInfo = new UpdateExerciseInfo();
        public UpdateExerciseInfoForm(IExerciseInfoRestClient exerciseInfoRestClient, IMessenger messenger)
        {
            _exerciseInfoRestClient = exerciseInfoRestClient;
            _messenger = messenger;
            InitializeComponent();
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateExerciseInfo.Name = NameTextBox.Text;
                updateExerciseInfo.Description = DescriptionRichTextBox.Text;
                await _exerciseInfoRestClient.UpdateAsync(Id, updateExerciseInfo);
                this.Close();
            }
            catch(Exception ex)
            {
                _messenger.Show(ex.Message);
            }
        }

        private async void LoadFormWithData()
        {
            var exerciseInfo = await _exerciseInfoRestClient.GetAsync(Id);

            NameTextBox.Text = exerciseInfo.Name;
            DescriptionRichTextBox.Text = exerciseInfo.Description;
        }

        private void UpdateExerciseInfoForm_Load(object sender, EventArgs e)
            => LoadFormWithData();
    }
}
