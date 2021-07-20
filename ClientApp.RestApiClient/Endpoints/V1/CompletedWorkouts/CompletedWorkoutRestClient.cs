using ClientApp.RestApiClient.Endpoints.V1.Errors;
using ClientApp.RestApiClient.Models.CompletedWorkouts;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.CompletedWorkouts
{
    public class CompletedWorkoutRestClient : RestClientWithAuth, ICompletedWorkoutRestClient
    {
        public CompletedWorkoutRestClient(IApiErrorHandler apiErrorHandler) : base(apiErrorHandler)
        { }

        public async Task<CompletedWorkoutDetails> GetAsync(Guid id)
        {
            var request = new RestRequest(ApiRoutes.CompletedWorkout.Route + $"/{id}", Method.GET);
            var response = await Client.ExecuteAsync<CompletedWorkoutDetails>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<CompletedWorkoutDetails>(response.Content);
        }

        public async Task<IEnumerable<CompletedWorkout>> BrowseAsync()
        {
            var request = new RestRequest(ApiRoutes.CompletedWorkout.Route, Method.GET);
            var response = await Client.ExecuteAsync<IEnumerable<CompletedWorkout>>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<IEnumerable<CompletedWorkout>>(response.Content);
        }

        public async Task CreateAsync(CreateCompletedWorkout createCompletedWorkout)
        {
            RestRequest request = new RestRequest(ApiRoutes.CompletedWorkout.Route, Method.POST);
            request.AddJsonBody(createCompletedWorkout);

            var response = await Client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.Created) _apiErrorHandler.Handle(response);
        }

        public async Task DeleteAsync(Guid id)
        {
            var request = new RestRequest(ApiRoutes.CompletedWorkout.Route + $"/{id}", Method.DELETE);
            var response = await Client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.NoContent) _apiErrorHandler.Handle(response);
        }
    }
}
