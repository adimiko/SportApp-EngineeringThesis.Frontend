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
    public partial class CreateExerciseInfoForm : Form
    {
        private IExerciseInfoRestClient _exerciseInfoRestClient;
        private CreateExerciseInfo createExerciseInfo = new CreateExerciseInfo();
        private readonly IMessenger _messenger;
        public CreateExerciseInfoForm(IExerciseInfoRestClient exerciseInfoRestClient, IMessenger messenger)
        {
            _exerciseInfoRestClient = exerciseInfoRestClient;
            _messenger = messenger;
            InitializeComponent();
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                createExerciseInfo.Name = NameTextBox.Text;
                createExerciseInfo.Description = DescriptionRichTextBox.Text;
                await _exerciseInfoRestClient.CreateAsync(createExerciseInfo);
                this.Close();
            }
            catch(Exception ex)
            {
                _messenger.Show(ex.Message);
                createExerciseInfo = new CreateExerciseInfo();
            }
        }
    }
}
