using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.CustomWorkoutRoutines
{
    public class CreateCustomWorkoutRoutine
    {
        public string Name { get; set; }
        public IList<CreateExercise> Exercises { get; set; } = new List<CreateExercise>();
    }
}
