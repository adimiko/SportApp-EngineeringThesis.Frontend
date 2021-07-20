using ClientApp.RestApiClient.Endpoints.V1.Errors;
using ClientApp.RestApiClient.Models.ExerciseInfo;
using ClientApp.RestApiClient.Settings;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.ExerciseInfo
{
    public class ExerciseInfoRestClient : RestClientWithAuth, IExerciseInfoRestClient
    {
        public ExerciseInfoRestClient(IApiErrorHandler apiErrorHandler) : base(apiErrorHandler)
        { }

        public async Task<ExerciseInfoDetailsModel> GetAsync(Guid id)
        {
            var request = new RestRequest(ApiRoutes.ExerciseInfo.Route + $"/{id}", Method.GET);
            var response = await Client.ExecuteAsync<ExerciseInfoDetailsModel>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<ExerciseInfoDetailsModel>(response.Content);
        }

        public async Task<IEnumerable<ExerciseInfoModel>> BrowseAsync()
        {
            var request = new RestRequest(ApiRoutes.ExerciseInfo.Route, Method.GET);
            var response = await Client.ExecuteAsync<IEnumerable<ExerciseInfoModel>>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<IEnumerable<ExerciseInfoModel>>(response.Content);
        }


        public async Task<IEnumerable<ExerciseInfoModel>> BrowseArchiveAsync()
        {
            var request = new RestRequest(ApiRoutes.ExerciseInfo.Route + "/archive", Method.GET);
            var response = await Client.ExecuteAsync<IEnumerable<ExerciseInfoModel>>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<IEnumerable<ExerciseInfoModel>>(response.Content);
        }



        public async Task CreateAsync(CreateExerciseInfo createExerciseInfo)
        {
            var request = new RestRequest(ApiRoutes.ExerciseInfo.Route, Method.POST);
            request.AddJsonBody(createExerciseInfo);

            var response = await Client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.Created) _apiErrorHandler.Handle(response);
        }

        public async Task UpdateAsync(Guid id, UpdateExerciseInfo updateExerciseInfo)
        {
            var request = new RestRequest(ApiRoutes.ExerciseInfo.Route + $"/{id}", Method.PUT);
            request.AddJsonBody(updateExerciseInfo);

            var response = await Client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
        }

        public async Task ArchiveAsync(Guid id)
        {
            var request = new RestRequest(ApiRoutes.ExerciseInfo.Route + $"/{id}/archive", Method.PATCH);
            var response = await Client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
        }

        public async Task RestoreAsync(Guid id)
        {
            var request = new RestRequest(ApiRoutes.ExerciseInfo.Route + $"/{id}/restore", Method.PATCH);
            var response = await Client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
        }
    }
}