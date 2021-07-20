using ClientApp.RestApiClient.Models.CustomWorkoutRoutines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.CustomWorkoutRoutines
{
    public interface ICustomWorkoutRoutineRestClient
    {
        Task<CustomWorkoutRoutineDetails> GetAsync(Guid id);
        Task<IEnumerable<CustomWorkoutRoutine>> BrowseAsync();
        Task<IEnumerable<CustomWorkoutRoutine>> BrowseArchiveAsync();
        Task CreateAsync(CreateCustomWorkoutRoutine createCustomWorkoutRoutine);
        Task ArchiveAsync(Guid id);
        Task RestoreAsync(Guid id);
    }
}
