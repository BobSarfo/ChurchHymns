using ChurchHymns.Core.Models;

namespace ChurchHymns.Core.Contracts.Services;

public interface ISampleDataService
{
    Task<IEnumerable<SampleOrder>> GetListDetailsDataAsync();
}
