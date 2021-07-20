using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.CustomWorkoutRoutines
{
    public class CreateExercise
    {
        public Guid ExerciseInfoId { get; set; }
        public int Order { get; set; }
        public int NumberOfSets { get; set; }
    }
}
