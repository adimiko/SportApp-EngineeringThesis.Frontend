using ClientApp.RestApiClient.Models.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.Accounts
{
    public interface IAccountsRestClient
    {
        Task<Account> GetAsync();
        Task ChangePassword(ChangePassword changePassword);
        Task DeleteAsync();
    }
}
