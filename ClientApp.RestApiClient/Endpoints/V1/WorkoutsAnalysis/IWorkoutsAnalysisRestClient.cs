using ClientApp.RestApiClient.Models.WorkoutsAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.WorkoutsAnalysis
{
    public interface IWorkoutsAnalysisRestClient
    {
        Task<WorkoutsAnalysisModel> GetWorkoutsAnalysisFromTheLastMonth();
    }
}
