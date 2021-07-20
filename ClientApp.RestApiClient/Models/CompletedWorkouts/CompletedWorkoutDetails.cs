using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.CompletedWorkouts
{
    public class CompletedWorkoutDetails
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string WorkoutNote { get; set; }
        public int Duration { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<CompletedExerciseDetails> Exercises { get; set; }

        public override string ToString()
        {
            string cw = $"{Name} \n" +
                        $"Workout note: \n {WorkoutNote} \n" +
                        $"Date: {Date.ToShortDateString()} \n" +
                        "\n";
            var numberOfExercises = Exercises.Count();
            for (int i = 1; i <= numberOfExercises; i++)
            {
                var exercise = Exercises.Where(x => x.Order == i).SingleOrDefault();

                cw += $"{exercise.Name} \n";

                var numberOfSets = exercise.Sets.Count();
                for (int x = 1; x <= numberOfSets; x++)
                {
                    var set = exercise.Sets.Where(z => z.Order == x).SingleOrDefault();
                    cw += $"{x}. Reps: {set.Reps} Weight: {set.Weight} \n";
                }
            }
            return cw;
        }
    }
}
