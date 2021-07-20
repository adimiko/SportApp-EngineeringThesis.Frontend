using ClientApp.RestApiClient.Endpoints.V1.Errors;
using ClientApp.RestApiClient.Models.SampleWorkoutRoutines;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.SampleWorkoutRoutines
{
    public class SampleWorkoutRoutineRestClient : RestClientWithAuth, ISampleWorkoutRoutineRestClient
    {
        public SampleWorkoutRoutineRestClient(IApiErrorHandler apiErrorHandler) : base(apiErrorHandler)
        { }

        public async Task<SampleWorkoutRoutineDetails> GetAsync(Guid id)
        {
            var request = new RestRequest(ApiRoutes.SampleWorkoutRoutine.Route + $"/{id}", Method.GET);
            var response = await Client.ExecuteAsync<SampleWorkoutRoutineDetails>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<SampleWorkoutRoutineDetails>(response.Content);
        }

        public async Task<IEnumerable<SampleWorkoutRoutine>> BrowseAsync()
        {
            var request = new RestRequest(ApiRoutes.SampleWorkoutRoutine.Route, Method.GET);
            var response = await Client.ExecuteAsync<IEnumerable<SampleWorkoutRoutine>>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<IEnumerable<SampleWorkoutRoutine>>(response.Content);
        }

        public async Task<IEnumerable<SampleWorkoutRoutine>> BrowseArchiveAsync()
        {
            var request = new RestRequest(ApiRoutes.SampleWorkoutRoutine.Route + "/archive", Method.GET);
            var response = await Client.ExecuteAsync<IEnumerable<SampleWorkoutRoutine>>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<IEnumerable<SampleWorkoutRoutine>>(response.Content);
        }

        public async Task CreateAsync(CreateSampleWorkoutRoutine createSampleWorkoutRoutine)
        {
            var request = new RestRequest(ApiRoutes.SampleWorkoutRoutine.Route, Method.POST);
            request.AddJsonBody(createSampleWorkoutRoutine);

            var response = await Client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.Created) _apiErrorHandler.Handle(response);
        }

        public async Task ArchiveAsync(Guid id)
        {
            var request = new RestRequest(ApiRoutes.SampleWorkoutRoutine.Route + $"/{id}/archive", Method.PATCH);
            var response = await Client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
        }

        public async Task RestoreAsync(Guid id)
        {
            var request = new RestRequest(ApiRoutes.SampleWorkoutRoutine.Route + $"/{id}/restore", Method.PATCH);
            var response = await Client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
        }
    }
}