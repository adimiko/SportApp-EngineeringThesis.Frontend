using ClientApp.RestApiClient.Endpoints.V1.Errors;
using ClientApp.RestApiClient.Models.Identity;
using ClientApp.RestApiClient.Settings;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.Identity
{
    public class IdentityRestClient : RestClientBase, IIdentityRestClient
    {

        public IdentityRestClient(IApiErrorHandler apiErrorHandler) : base(apiErrorHandler)
        {}

        public async Task Login(Login login)
        {
            var request = new RestRequest(ApiRoutes.Identity.LoginAsync, Method.POST);
            request.AddJsonBody(login);

            var response = await Client.ExecuteAsync(request);
            if((int)response.StatusCode == 0) throw new Exception("No connection to the server.\nCheck your internet connection or contact the server administrator.");
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            else
            {
                RestClinetSettings.Jwt = JsonConvert.DeserializeObject<JWT>(response.Content).jwt;
                Client.Authenticator = new JwtAuthenticator(RestClinetSettings.Jwt);
            }
        }

        public async Task RegisterAsync(Register register)
        {
            var request = new RestRequest(ApiRoutes.Identity.RegisterAsync, Method.POST);
            request.AddJsonBody(register);

            var response = await Client.ExecuteAsync(request);
            if ((int)response.StatusCode == 0) throw new Exception("No connection to the server.\nCheck your internet connection or contact the server administrator.");
            if (response.StatusCode != HttpStatusCode.Created) _apiErrorHandler.Handle(response);
        }
    }
}
