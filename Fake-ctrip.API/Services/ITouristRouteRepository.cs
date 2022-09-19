using Fake_ctrip.API.Models;

namespace Fake_ctrip.API.Services
{
    public interface ITouristRouteRepository
    {
        IEnumerable<TouristRoute> GetTouristRoutes(string? keyword, string? ratingOperatorType, int? ratingVal);
        TouristRoute GetTouristRoute(Guid id);
        bool HasTouristRoute(Guid id);
        IEnumerable<TouristRoutePicture> GetPicturesByTouristRouteId(Guid touristRouteId);
        TouristRoutePicture GetPicture(int id);
    }
}
