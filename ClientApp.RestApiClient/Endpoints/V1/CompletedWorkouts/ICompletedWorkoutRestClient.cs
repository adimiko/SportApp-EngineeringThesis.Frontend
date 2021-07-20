using ClientApp.RestApiClient.Models.CompletedWorkouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.CompletedWorkouts
{
    public interface ICompletedWorkoutRestClient
    {
        Task<CompletedWorkoutDetails> GetAsync(Guid id);
        Task<IEnumerable<CompletedWorkout>> BrowseAsync();
        Task CreateAsync(CreateCompletedWorkout createCompletedWorkout);
        Task DeleteAsync(Guid id);
    }
}
