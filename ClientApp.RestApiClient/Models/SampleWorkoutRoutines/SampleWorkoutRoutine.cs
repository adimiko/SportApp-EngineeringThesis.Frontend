using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.SampleWorkoutRoutines
{
    public class SampleWorkoutRoutine
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
            => Name;
    }
}
