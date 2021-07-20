using ClientApp.RestApiClient.Models.Errors;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.Errors
{
    public class ApiErrorHandler : IApiErrorHandler
    {
        public void Handle(IRestResponse response)
        {
            var error = JsonConvert.DeserializeObject<Error>(response.Content);
            throw new Exception(error.Message);
        }
    }
}
