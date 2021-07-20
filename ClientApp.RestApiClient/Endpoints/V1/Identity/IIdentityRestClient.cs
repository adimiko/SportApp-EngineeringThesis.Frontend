using ClientApp.RestApiClient.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.Identity
{
    public interface IIdentityRestClient
    {
        Task Login(Login login);
        Task RegisterAsync(Register register);
    }
}
