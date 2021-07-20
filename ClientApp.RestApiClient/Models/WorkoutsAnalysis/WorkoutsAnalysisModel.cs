using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.WorkoutsAnalysis
{
    public class WorkoutsAnalysisModel
    {
        public double VolumePercent { get; set; }
        public double NumberOfCompletedWorkoutsPercent { get; set; }
        public double DurationPercent { get; set; }

        public override string ToString()
        {
            var wa = "Last Month \n";
            wa += "SUMMARY \n";

            wa += $"Volume: {VolumePercent}% ";
            if (VolumePercent > 0) wa += "↗ \n";
            else if (VolumePercent < 0) wa += "↘ \n";
            else wa += "- \n";

            wa += $"NumberOfCompletedWorkouts: {NumberOfCompletedWorkoutsPercent}% ";
            if (NumberOfCompletedWorkoutsPercent > 0) wa += "↗ \n";
            else if (NumberOfCompletedWorkoutsPercent < 0) wa += "↘ \n";
            else wa += "- \n";

            wa += $"Duration: {DurationPercent}% ";
            if (DurationPercent > 0) wa += "↗ \n";
            else if (DurationPercent < 0) wa += "↘ \n";
            else wa += "- \n";

            return wa;
        }
    }
}
