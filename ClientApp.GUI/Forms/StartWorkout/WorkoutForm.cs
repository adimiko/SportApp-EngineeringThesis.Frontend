using ClientApp.GUI.Extensions;
using ClientApp.RestApiClient.Endpoints.V1.CompletedWorkouts;
using ClientApp.RestApiClient.Models.CompletedWorkouts;
using ClientApp.RestApiClient.Models.CustomWorkoutRoutines;
using ClientApp.RestApiClient.Models.SampleWorkoutRoutines;
using ClientApp.RestApiClient.Models.WorkoutRoutines;
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
    public partial class WorkoutForm : Form
    {

        private readonly ICompletedWorkoutRestClient _completedWorkoutRestClient;
        private readonly IMessenger _messenger;
        public WorkoutRoutine workoutRoutine { get; set; }

        private int Duration = 0;

        private CreateCompletedWorkout createCompletedWorkout = new CreateCompletedWorkout();


        public WorkoutForm(ICompletedWorkoutRestClient completedWorkoutRestClient, IMessenger messenger)
        {
            _completedWorkoutRestClient = completedWorkoutRestClient;
            _messenger = messenger;
            InitializeComponent();
        }

        private void WorkoutForm_Load(object sender, EventArgs e)
        {
            WorkoutNameLabel.Text = workoutRoutine.Name;
            var numberOfExercises = workoutRoutine.Exercises.Count();


            var xForExerciseNameLabel = 0;

            var y = 0;

            for(var i = 1; i<= numberOfExercises; i++)
            {
                var exercise = workoutRoutine.Exercises.Where(x => x.Order == i).SingleOrDefault();

                var label = new Label();
                label.Name = "Exercise " + i;
                label.ForeColor = Color.White;
                label.AutoSize = true;
                label.Text = exercise.Name;
                label.Location = new Point(xForExerciseNameLabel, y);

                y += 25;



                for(var x = 1; x<= exercise.NumberOfSets; x++)
                {
                    var repsLabel = new Label();
                    repsLabel.AutoSize = true;
                    repsLabel.ForeColor = Color.White;
                    repsLabel.Text = "Reps: ";
                    repsLabel.Location = new Point(0, y);

                    var repsNumericUpDown = new NumericUpDown();
                    repsNumericUpDown.Name = $"Reps {i}-{x}";
                    repsNumericUpDown.Location = new Point(40, y);
                    repsNumericUpDown.Maximum = 1000;



                    var weightLabel = new Label();
                    weightLabel.AutoSize = true;
                    weightLabel.ForeColor = Color.White;
                    weightLabel.Text = "Weight: ";
                    weightLabel.Location = new Point(160, y);

                    var weightNumericUpDown = new NumericUpDown();
                    weightNumericUpDown.Name = $"Weight {i}-{x}";
                    weightNumericUpDown.Location = new Point(210, y);
                    weightNumericUpDown.Maximum = 1000;

                    y += 25;
                    ContentPanel.Controls.Add(repsLabel);
                    ContentPanel.Controls.Add(weightLabel);
                    ContentPanel.Controls.Add(repsNumericUpDown);
                    ContentPanel.Controls.Add(weightNumericUpDown);
                }


                ContentPanel.Controls.Add(label);
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                createCompletedWorkout.Name = WorkoutNameLabel.Text;
                createCompletedWorkout.WorkoutNote = WorkoutNoteRichTextBox.Text;
                createCompletedWorkout.Duration = Duration;

                var numberOfExercises = workoutRoutine.Exercises.Count();

                for (var i = 1; i <= numberOfExercises; i++)
                {
                    var exercise = workoutRoutine.Exercises.Where(x => x.Order == i).SingleOrDefault();
                    var createCompletedExercise = new CreateCompletedExercise();
                    createCompletedExercise.ExerciseInfoId = exercise.ExerciseInfoId;
                    createCompletedExercise.Order = i;
                    

                    for (var x = 1; x <= exercise.NumberOfSets; x++)
                    {
                        var createCompletedSet = new CreateCompletedSet();

                        createCompletedSet.Order = x;

                        var numericUpDownName = $"Reps {i}-{x}";
                        var numericUpDown = ContentPanel.Controls[numericUpDownName] as NumericUpDown;
                        createCompletedSet.Reps = Convert.ToInt32(numericUpDown.Value);

                        numericUpDownName = $"Weight {i}-{x}";
                        numericUpDown = ContentPanel.Controls[numericUpDownName] as NumericUpDown;
                        createCompletedSet.Weight = Convert.ToInt32(numericUpDown.Value);


                        createCompletedExercise.Sets.Add(createCompletedSet);
                    }
                    createCompletedWorkout.Exercises.Add(createCompletedExercise);
                }


                await _completedWorkoutRestClient.CreateAsync(createCompletedWorkout);
                this.Close();
            }
            catch (Exception ex)
            {
                _messenger.Show(ex.Message);
                createCompletedWorkout = new CreateCompletedWorkout();
            }
        }

        private void WorkoutTimer_Tick(object sender, EventArgs e)
        {
            Duration++;
            TimeSpan ts = TimeSpan.FromSeconds(Duration);
            DurationLabel.Text = ts.ToString();
        }
    }
}
