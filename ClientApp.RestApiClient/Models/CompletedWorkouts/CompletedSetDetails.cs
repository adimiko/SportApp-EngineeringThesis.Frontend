using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.CompletedWorkouts
{
    public class CompletedSetDetails
    {
        public Guid Id { get; set; }
        public int Order { get; set; }
        public int Reps { get; set; }
        public float Weight { get; set; }
    }
}
