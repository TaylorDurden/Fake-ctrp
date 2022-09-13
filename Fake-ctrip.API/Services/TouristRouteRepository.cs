using Fake_ctrip.API.Database;
using Fake_ctrip.API.Models;

namespace Fake_ctrip.API.Services
{
    public class TouristRouteRepository : ITouristRouteRepository
    {
        private AppDbContext _context;
        public TouristRouteRepository(AppDbContext context)
        {
            _context = context;
        }

        public TouristRoute GetTouristRoute(Guid id)
        {
            return _context.TouristRoutes.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return _context.TouristRoutes;
        }
    }
}
