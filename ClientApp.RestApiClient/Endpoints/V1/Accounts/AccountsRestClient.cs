using ClientApp.RestApiClient.Endpoints.V1.Errors;
using ClientApp.RestApiClient.Models.Accounts;
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

namespace ClientApp.RestApiClient.Endpoints.V1.Accounts
{
    public class AccountsRestClient : RestClientWithAuth, IAccountsRestClient
    {
        public AccountsRestClient(IApiErrorHandler apiErrorHandler)
            : base(apiErrorHandler) { }



        public async Task<Account> GetAsync()
        {
            var request = new RestRequest(ApiRoutes.Account.GetAsync, Method.GET);
            Client.Authenticator = new JwtAuthenticator(RestClinetSettings.Jwt);
            var response = await Client.ExecuteAsync<Account>(request);
            if(response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
            return JsonConvert.DeserializeObject<Account>(response.Content);
        }

        public async Task ChangePassword(ChangePassword changePassword)
        {
            var request = new RestRequest(ApiRoutes.Account.Route + "/change-password", Method.PATCH);
            request.AddJsonBody(changePassword);

            var response = await Client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.OK) _apiErrorHandler.Handle(response);
        }

        public async Task DeleteAsync()
        {
            var request = new RestRequest(ApiRoutes.Account.Route, Method.DELETE);
            var response = await Client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.NoContent) _apiErrorHandler.Handle(response);
        }
    }
}
