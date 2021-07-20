using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.WorkoutRoutines
{
    public class ExerciseDetails
    {
        public Guid Id { get; set; }
        public Guid ExerciseInfoId { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public int NumberOfSets { get; set; }
    }
}
