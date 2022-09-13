using Fake_ctrip.API.Models;

namespace Fake_ctrip.API.Services
{
    public interface ITouristRouteRepository
    {
        IEnumerable<TouristRoute> GetTouristRoutes();
        TouristRoute GetTouristRoute(Guid id);
    }
}
