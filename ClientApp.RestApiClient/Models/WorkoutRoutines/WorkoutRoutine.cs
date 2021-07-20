using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.WorkoutRoutines
{
    public abstract class WorkoutRoutine
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ExerciseDetails> Exercises { get; set; }

        public override string ToString()
        {
            string wr = $"Name: {Name} \n" +
                         $"Exercises: \n";

            foreach (var exercise in Exercises)
                wr += $"Name: {exercise.Name} Sets: {exercise.NumberOfSets}  \n";


            return wr;
        }
    }
}
