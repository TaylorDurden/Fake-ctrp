using Fake_ctrip.API.Models;
using System.Text.RegularExpressions;

namespace Fake_ctrip.API.Services
{
    //public class MockTouristRouteRepository : ITouristRouteRepository
    //{
    //    private List<TouristRoute> _routes;
    //    public MockTouristRouteRepository() {
    //        if (_routes == null) {
    //            InitTouristRoutes();
    //        }
    //    }
    //    private void InitTouristRoutes() 
    //    {
    //        _routes = new List<TouristRoute> {
    //            new TouristRoute {
    //                Id = Guid.NewGuid(),
    //                Title = "黄山",
    //                Description = "黄山5A景点",
    //                OriginalPrice = 1299,
    //                Features = "<P>吃住行</p>",
    //                Fees = "<p>交通费自理</p>",
    //                Notes = "<p>注意安全</p>",
    //            },
    //            new TouristRoute {
    //                Id = Guid.NewGuid(),
    //                Title = "华山",
    //                Description = "华山4A景点",
    //                OriginalPrice = 129,
    //                Features = "<P>索道，栈道</p>",
    //                Fees = "<p>交通费自理</p>",
    //                Notes = "<p>注意安全！</p>",
    //            },
    //        };
    //    }
    //    public TouristRoute GetTouristRoute(Guid id)
    //    {
    //        return _routes.FirstOrDefault(x => x.Id == id);
    //    }

    //    public IEnumerable<TouristRoute> GetTouristRoutes()
    //    {
    //        return _routes;
    //    }

    //    public bool HasTouristRoute(Guid id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<TouristRoutePicture> GetPicturesByTouristRouteId(Guid touristRouteId)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
