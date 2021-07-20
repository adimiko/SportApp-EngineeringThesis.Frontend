using ClientApp.RestApiClient.Endpoints.V1.Errors;
using ClientApp.RestApiClient.Settings;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1
{
    public abstract class RestClientWithAuth : RestClientBase
    {
        public RestClientWithAuth(IApiErrorHandler apiErrorHandler) : base(apiErrorHandler)
            => Client.Authenticator = new JwtAuthenticator(RestClinetSettings.Jwt);

    }
}
