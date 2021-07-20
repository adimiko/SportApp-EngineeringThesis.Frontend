using ClientApp.RestApiClient.Models.ExerciseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.ExerciseInfo
{
    public interface IExerciseInfoRestClient
    {
        Task<ExerciseInfoDetailsModel> GetAsync(Guid id);
        Task<IEnumerable<ExerciseInfoModel>> BrowseAsync();
        Task<IEnumerable<ExerciseInfoModel>> BrowseArchiveAsync();
        Task CreateAsync(CreateExerciseInfo createExerciseInfo);
        Task UpdateAsync(Guid id, UpdateExerciseInfo updateExerciseInfo);
        Task ArchiveAsync(Guid id);
        Task RestoreAsync(Guid id);
    }
}
