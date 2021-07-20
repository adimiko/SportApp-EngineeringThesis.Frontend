using ClientApp.RestApiClient.Models.WorkoutsStats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.WorkoutsStats
{
    public interface IWorkoutsStatsRestClient
    {
        Task<WorkoutsStatsModel> GetGlobalWorkoutsStatsAsync();
        Task<WorkoutsStatsModel> GetWorkoutsStatsCurrentWeekAsync();
        Task<WorkoutsStatsModel> GetWorkoutsStatsCurrentMonthAsync();
        Task<WorkoutsStatsModel> GetWorkoutsStatsCurrentYearAsync();
    }
}