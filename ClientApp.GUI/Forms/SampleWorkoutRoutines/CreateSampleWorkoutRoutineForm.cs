using ClientApp.GUI.Extensions;
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

namespace ClientApp.GUI.Forms.SampleWorkoutRoutines
{
    public partial class CreateSampleWorkoutRoutineForm : Form
    {
        private readonly IExerciseInfoRestClient _exerciseInfoRestClient;
        private readonly ISampleWorkoutRoutineRestClient _sampleWorkoutRoutineRestClient;
        private readonly IMessenger _messenger;
        private int NumberOfExercises;

        private CreateSampleWorkoutRoutine createSampleWorkoutRoutine = new CreateSampleWorkoutRoutine();

        public CreateSampleWorkoutRoutineForm(IExerciseInfoRestClient exerciseInfoRestClient, ISampleWorkoutRoutineRestClient sampleWorkoutRoutineRestClient, IMessenger messenger)
        {
            _exerciseInfoRestClient = exerciseInfoRestClient;
            _sampleWorkoutRoutineRestClient = sampleWorkoutRoutineRestClient;
            _messenger = messenger;
            InitializeComponent();
        }

        private async void OkButton_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            var exerciseInfo = await _exerciseInfoRestClient.BrowseAsync();
            var ei = exerciseInfo.ToArray();

            var xNumericUpDown = 0;
            var y = 0;
            for (int i = 1; i <= HowManyExercisesNumericUpDown.Value; i++)
            {
                var comboBox = new ComboBox();
                var numericUpDown = new NumericUpDown();
                var exerciseLabel = new Label();
                var setLabel = new Label();

                exerciseLabel.Text = "Exercise " + i;
                setLabel.Text = "Sets";

                exerciseLabel.ForeColor = Color.White;
                setLabel.ForeColor = Color.White;
                exerciseLabel.BackColor = Color.Transparent;
                setLabel.BackColor = Color.Transparent;

                exerciseLabel.Location = new Point(0, y);
                setLabel.Location = new Point(410, y);
                y += 20;

                comboBox.Location = new Point(0, y);
                comboBox.Width = 400;
                xNumericUpDown = comboBox.Width + 10;
                numericUpDown.Location = new Point(xNumericUpDown, y);
                numericUpDown.Width = 37;
                y += 30;

                comboBox.Name = "comboBox" + i;
                numericUpDown.Name = "numericUpDown" + i;


                numericUpDown.Minimum = 1;
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox.Items.AddRange(ei);


                ContentPanel.Controls.Add(comboBox);
                ContentPanel.Controls.Add(numericUpDown);
                ContentPanel.Controls.Add(exerciseLabel);
                ContentPanel.Controls.Add(setLabel);
            }

            NumberOfExercises = Convert.ToInt32(HowManyExercisesNumericUpDown.Value);
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                createSampleWorkoutRoutine.Name = NameTextBox.Text;
                for (int i = 1; i <= HowManyExercisesNumericUpDown.Value; i++)
                {
                    var comboBoxName = "comboBox" + i;
                    var numericUpDownName = "numericUpDown" + i;

                    var comboBox = ContentPanel.Controls[comboBoxName] as ComboBox;
                    var numericUpDown = ContentPanel.Controls[numericUpDownName] as NumericUpDown;

                    
                    if (comboBox == null || comboBox.SelectedItem == null) return;

                    var exercise = comboBox.SelectedItem as ExerciseInfoModel;

                    var exerciseDetails = new CreateExercise();
                    exerciseDetails.ExerciseInfoId = exercise.Id;
                    exerciseDetails.NumberOfSets = Convert.ToInt32(numericUpDown.Value);
                    exerciseDetails.Order = i;

                    createSampleWorkoutRoutine.Exercises.Add(exerciseDetails);
                }

                await _sampleWorkoutRoutineRestClient.CreateAsync(createSampleWorkoutRoutine);
                this.Close();
            }
            catch(Exception ex)
            {
                _messenger.Show(ex.Message);
                createSampleWorkoutRoutine = new CreateSampleWorkoutRoutine();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HowManyExercisesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
