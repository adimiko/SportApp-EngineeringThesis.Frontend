using ClientApp.RestApiClient.Models.BodyMeasurements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Endpoints.V1.BodyMeasurements
{
    public interface IBodyMeasurementsRestClient
    {
        Task<BodyMeasurementDetails> GetAsync(Guid id);
        Task<IEnumerable<BodyMeasurement>> BrowseAsync();
        Task CreateAsync(CreateBodyMeasurement createBodyMeasurement);
        Task UpdateAsync(Guid id, UpdateBodyMeasurement updateBodyMeasurement);
        Task DeleteAsync(Guid id);
    }
}
