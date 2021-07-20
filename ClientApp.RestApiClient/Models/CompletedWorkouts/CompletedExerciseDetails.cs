using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.CompletedWorkouts
{
    public class CompletedExerciseDetails
    {
        public Guid Id { get; set; }
        public Guid ExerciseInfoId { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public IEnumerable<CompletedSetDetails> Sets { get; set; }
    }
}
