using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.CompletedWorkouts
{
    public class CreateCompletedExercise
    {
        public Guid ExerciseInfoId { get; set; }
        public int Order { get; set; }
        public IList<CreateCompletedSet> Sets { get; set; } = new List<CreateCompletedSet>();
    }
}
