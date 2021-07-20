using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.WorkoutsStats
{
    public class WorkoutsStatsModel
    {
        public double Volume { get; set; }
        public int NumberOfCompletedWorkouts { get; set; }
        public int Duration { get; set; }
    }
}
