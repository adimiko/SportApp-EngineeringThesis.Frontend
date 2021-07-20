using ClientApp.RestApiClient.Models.SampleWorkoutRoutines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.SampleWorkoutRoutines
{
    public interface ISampleWorkoutRoutineRestClient
    {
        Task<SampleWorkoutRoutineDetails> GetAsync(Guid id);
        Task<IEnumerable<SampleWorkoutRoutine>> BrowseAsync();
        Task<IEnumerable<SampleWorkoutRoutine>> BrowseArchiveAsync();
        Task CreateAsync(CreateSampleWorkoutRoutine createSampleWorkoutRoutine);
        Task ArchiveAsync(Guid id);
        Task RestoreAsync(Guid id);
    }
}
