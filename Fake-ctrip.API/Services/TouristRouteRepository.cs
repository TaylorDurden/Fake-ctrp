using Fake_ctrip.API.Database;
using Fake_ctrip.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fake_ctrip.API.Services
{
    public class TouristRouteRepository : ITouristRouteRepository
    {
        private AppDbContext _context;
        public TouristRouteRepository(AppDbContext context)
        {
            _context = context;
        }

        public TouristRoutePicture GetPicture(int id)
        {
            return _context.TouristRoutePictures.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<TouristRoutePicture> GetPicturesByTouristRouteId(Guid touristRouteId)
        {
            return _context.TouristRoutePictures.Where(x => x.TouristRouteId == touristRouteId).ToList();
        }

        public TouristRoute GetTouristRoute(Guid id)
        {
            return _context.TouristRoutes.Include(x => x.TouristRoutePictures).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes(string? keyword, string? ratingOperatorType, int? ratingVal)
        {
            IQueryable<TouristRoute> rlt = _context.TouristRoutes.Include(x => x.TouristRoutePictures);
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                keyword = keyword.Trim();
                rlt = rlt.Where(x => x.Title.Contains(keyword));
            }
            if (!string.IsNullOrWhiteSpace(ratingOperatorType) && ratingVal.HasValue && ratingVal >= 0)
            {
                rlt = ratingOperatorType switch
                {
                    "largerThan" => rlt.Where(x => x.Rating >= ratingVal),
                    "lessThan" => rlt.Where(x => x.Rating <= ratingVal),
                    _ => rlt.Where(x => x.Rating == ratingVal),
                };
            }
            return rlt.ToList();
        }

        public bool HasTouristRoute(Guid id)
        {
            return _context.TouristRoutes.Any(x => x.Id == id);
        }
    }
}
