using ClientApp.GUI.Extensions;
using ClientApp.RestApiClient.Endpoints.V1.WorkoutsAnalysis;
using ClientApp.RestApiClient.Endpoints.V1.WorkoutsStats;
using ClientApp.RestApiClient.Models.WorkoutsStats;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.GUI.Forms.WorkoutStats
{
    public partial class WorkoutsStatsForm : Form
    {
        private readonly IWorkoutsStatsRestClient _workoutsStatsRestClient;
        private readonly IWorkoutsAnalysisRestClient _workoutsAnalysisRestClient;
        private readonly IMessenger _messenger;

        public WorkoutsStatsForm(IWorkoutsStatsRestClient workoutsStatsRestClient, IWorkoutsAnalysisRestClient workoutsAnalysisRestClient, IMessenger messenger)
        {
            _workoutsStatsRestClient = workoutsStatsRestClient;
            _workoutsAnalysisRestClient = workoutsAnalysisRestClient;
            _messenger = messenger;
            InitializeComponent();
        }

        private async void GlobalButton_Click(object sender, EventArgs e)
            => GetStats("Global Stats", await _workoutsStatsRestClient.GetGlobalWorkoutsStatsAsync());

        private async void CurrentYearButton_Click(object sender, EventArgs e)
            => GetStats("Current Year Stats", await _workoutsStatsRestClient.GetWorkoutsStatsCurrentYearAsync());


        private async void CurrentMonthButton_Click(object sender, EventArgs e)
            => GetStats("Current Month Stats", await _workoutsStatsRestClient.GetWorkoutsStatsCurrentMonthAsync());


        private async void CurrentWeekButton_Click(object sender, EventArgs e)
            => GetStats("Current Week Stats", await _workoutsStatsRestClient.GetWorkoutsStatsCurrentWeekAsync());


        private void WorkoutsStatsForm_Load(object sender, EventArgs e)
        {
            CurrentWeekButton_Click(sender, e);
        }

        private void GetStats(string statsName, WorkoutsStatsModel stats)
        {
            StatsTextLabel.Text = statsName;
            VolumeLabel.Text = stats.Volume.ToString();
            CompletedWorkoutsLabel.Text = stats.NumberOfCompletedWorkouts.ToString();
            DurationLabel.Text = TimeSpan.FromSeconds(stats.Duration).ToString();
        }

        private async void AnalysisButton_Click(object sender, EventArgs e)
        {
            try
            {
                var workoutsAnalysis = await _workoutsAnalysisRestClient.GetWorkoutsAnalysisFromTheLastMonth();
                MessageBox.Show(workoutsAnalysis.ToString());
            }
            catch(Exception ex)
            {
                _messenger.Show(ex.Message);
            }
        }
    }
}
