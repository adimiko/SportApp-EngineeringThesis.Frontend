using ClientApp.RestApiClient.Endpoints.V1.Errors;
using ClientApp.RestApiClient.Models.CustomWorkoutRoutines;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.CustomWorkoutRoutines
{
    public class CustomWorkoutRoutineRestClient : RestClientWithAuth, ICustomWorkoutRoutineRestClient
    {
        public CustomWorkoutRoutineRestClient(IApiErrorHandler apiErrorHandler) : base(apiErrorHandler)
        { }

        public async Task<CustomWorkoutRoutineDetails> GetAsync(Guid id)
        {
            var request = new RestRequest(ApiRoutes.CustomWorkoutRoutine.Route + $"/{id}", Method.GET);
            var response = await Client.ExecuteAsync<CustomWorkoutRoutineDetails>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<CustomWorkoutRoutineDetails>(response.Content);
        }

        public async Task<IEnumerable<CustomWorkoutRoutine>> BrowseAsync()
        {
            var request = new RestRequest(ApiRoutes.CustomWorkoutRoutine.Route, Method.GET);
            var response = await Client.ExecuteAsync<IEnumerable<CustomWorkoutRoutine>>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<IEnumerable<CustomWorkoutRoutine>>(response.Content);
        }

        public async Task<IEnumerable<CustomWorkoutRoutine>> BrowseArchiveAsync()
        {
            var request = new RestRequest(ApiRoutes.CustomWorkoutRoutine.Route + "/archive", Method.GET);
            var response = await Client.ExecuteAsync<IEnumerable<CustomWorkoutRoutine>>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<IEnumerable<CustomWorkoutRoutine>>(response.Content);
        }

        public async Task ArchiveAsync(Guid id)
        {
            var request = new RestRequest(ApiRoutes.CustomWorkoutRoutine.Route + $"/{id}/archive", Method.PATCH);
            var response = await Client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
        }

        public async Task CreateAsync(CreateCustomWorkoutRoutine createCustomWorkoutRoutine)
        {
            var request = new RestRequest(ApiRoutes.CustomWorkoutRoutine.Route, Method.POST);
            request.AddJsonBody(createCustomWorkoutRoutine);

            var response = await Client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.Created) _apiErrorHandler.Handle(response);
        }

        public async Task RestoreAsync(Guid id)
        {
            var request = new RestRequest(ApiRoutes.CustomWorkoutRoutine.Route + $"/{id}/restore", Method.PATCH);
            var response = await Client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
        }
    }
}
