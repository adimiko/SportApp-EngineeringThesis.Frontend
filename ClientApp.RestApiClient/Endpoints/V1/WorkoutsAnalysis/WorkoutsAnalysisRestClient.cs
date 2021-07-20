using ClientApp.RestApiClient.Endpoints.V1.Errors;
using ClientApp.RestApiClient.Models.WorkoutsAnalysis;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.WorkoutsAnalysis
{
    public class WorkoutsAnalysisRestClient : RestClientWithAuth, IWorkoutsAnalysisRestClient
    {
        public WorkoutsAnalysisRestClient(IApiErrorHandler apiErrorHandler) : base(apiErrorHandler)
        { }

        public async Task<WorkoutsAnalysisModel> GetWorkoutsAnalysisFromTheLastMonth()
        {
            var request = new RestRequest(ApiRoutes.WorkoutsAnalysis.GetWorkoutsAnalysisFromTheLastMonthAsync, Method.GET);
            var response = await Client.ExecuteAsync<WorkoutsAnalysisModel>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<WorkoutsAnalysisModel>(response.Content);
        }
    }
}
