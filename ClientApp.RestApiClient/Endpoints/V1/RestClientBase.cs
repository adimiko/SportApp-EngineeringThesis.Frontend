using ClientApp.RestApiClient.Endpoints.V1.Errors;
using ClientApp.RestApiClient.Settings;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1
{
    public abstract class RestClientBase
    {
        private readonly RestClient _client;
        protected readonly IApiErrorHandler _apiErrorHandler;
        protected RestClient Client => _client;

        public RestClientBase(IApiErrorHandler apiErrorHandler)
        {
            _apiErrorHandler = apiErrorHandler;
            _client = new RestClient(RestClinetSettings.BaseUrl);
            _client.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
        }

    }
}
