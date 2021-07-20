using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.SampleWorkoutRoutines
{
    public class CreateSampleWorkoutRoutine
    {
        public string Name { get; set; }
        public IList<CreateExercise> Exercises { get; set; } = new List<CreateExercise>();
    }
}
