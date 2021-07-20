using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.CompletedWorkouts
{
    public class CompletedWorkout
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string WorkoutNote { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
            => $"{Name} {Date.ToShortDateString()}";

    }
}
