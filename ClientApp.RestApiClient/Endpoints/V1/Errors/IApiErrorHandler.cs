using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.Errors
{
    public interface IApiErrorHandler
    {
        void Handle(IRestResponse response);
    }
}
