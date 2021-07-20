using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.CompletedWorkouts
{
    public class CreateCompletedWorkout
    {
        public string Name { get; set; }
        public string WorkoutNote { get; set; }
        public int Duration { get; set; }
        public IList<CreateCompletedExercise> Exercises { get; set; } = new List<CreateCompletedExercise>();
    }
}
