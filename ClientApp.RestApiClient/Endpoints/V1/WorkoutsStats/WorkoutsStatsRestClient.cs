using ClientApp.RestApiClient.Endpoints.V1.Errors;
using ClientApp.RestApiClient.Models.WorkoutsStats;
using ClientApp.RestApiClient.Settings;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.WorkoutsStats
{
    public class WorkoutsStatsRestClient : RestClientWithAuth, IWorkoutsStatsRestClient
    {
        public WorkoutsStatsRestClient(IApiErrorHandler apiErrorHandler) : base(apiErrorHandler)
        { }

        public async Task<WorkoutsStatsModel> GetGlobalWorkoutsStatsAsync()
        {
            var request = new RestRequest(ApiRoutes.WorkoutsStats.GetGlobalWorkoutsStatsAsync, Method.GET);
            var response = await Client.ExecuteAsync<WorkoutsStatsModel>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<WorkoutsStatsModel>(response.Content);
        }

        public async Task<WorkoutsStatsModel> GetWorkoutsStatsCurrentYearAsync()
        {
            var request = new RestRequest(ApiRoutes.WorkoutsStats.GetWorkoutsStatsCurrentYearAsync, Method.GET);
            var response = await Client.ExecuteAsync<WorkoutsStatsModel>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<WorkoutsStatsModel>(response.Content);
        }

        public async Task<WorkoutsStatsModel> GetWorkoutsStatsCurrentMonthAsync()
        {
            var request = new RestRequest(ApiRoutes.WorkoutsStats.GetWorkoutsStatsCurrentMonthAsync, Method.GET);
            var response = await Client.ExecuteAsync<WorkoutsStatsModel>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<WorkoutsStatsModel>(response.Content);
        }

        public async Task<WorkoutsStatsModel> GetWorkoutsStatsCurrentWeekAsync()
        {
            var request = new RestRequest(ApiRoutes.WorkoutsStats.GetWorkoutsStatsCurrentWeekAsync, Method.GET);
            var response = await Client.ExecuteAsync<WorkoutsStatsModel>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<WorkoutsStatsModel>(response.Content);
        }


    }
}
