using ClientApp.RestApiClient.Endpoints.V1.Errors;
using ClientApp.RestApiClient.Models.BodyMeasurements;
using ClientApp.RestApiClient.Settings;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.BodyMeasurements
{
    public class BodyMeasurementsRestClient : RestClientWithAuth, IBodyMeasurementsRestClient
    {
        public BodyMeasurementsRestClient(IApiErrorHandler apiErrorHandler) : base(apiErrorHandler)
        { }

        public async Task<BodyMeasurementDetails> GetAsync(Guid id)
        {
            var request = new RestRequest(ApiRoutes.BodyMeasurement.Route + $"/{id}", Method.GET);
            var response = await Client.ExecuteAsync<BodyMeasurementDetails>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<BodyMeasurementDetails>(response.Content);
        }

        public async Task<IEnumerable<BodyMeasurement>> BrowseAsync()
        {
            var request = new RestRequest(ApiRoutes.BodyMeasurement.Route, Method.GET);
            var response = await Client.ExecuteAsync<IEnumerable<BodyMeasurement>>(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<IEnumerable<BodyMeasurement>>(response.Content);
        }

        public async Task CreateAsync(CreateBodyMeasurement createBodyMeasurement)
        {
            var request = new RestRequest(ApiRoutes.BodyMeasurement.Route, Method.POST);
            request.AddJsonBody(createBodyMeasurement);

            var response = await Client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.Created) _apiErrorHandler.Handle(response);
        }


        public async Task UpdateAsync(Guid id, UpdateBodyMeasurement updateBodyMeasurement)
        {
            var request = new RestRequest(ApiRoutes.BodyMeasurement.Route + $"/{id}", Method.PUT);
            request.AddJsonBody(updateBodyMeasurement);
            var response = await Client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
        }

        public async Task DeleteAsync(Guid id)
        {
            var request = new RestRequest(ApiRoutes.BodyMeasurement.Route + $"/{id}", Method.DELETE);
            var response = await Client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.NoContent) _apiErrorHandler.Handle(response);
        }

    }
}
