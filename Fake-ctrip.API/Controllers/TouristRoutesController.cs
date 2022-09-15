using AutoMapper;
using Fake_ctrip.API.Models;
using Fake_ctrip.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fake_ctrip.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristRoutesController : ControllerBase
    {
        private ITouristRouteRepository _touristRouteRepository;
        private readonly IMapper _mapper;

        public TouristRoutesController(ITouristRouteRepository touristRouteRepository, IMapper mapper)
        {
            _touristRouteRepository = touristRouteRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [HttpHead]
        public IActionResult GetTouristRoutes()
        {
            var routesFromRepo = _touristRouteRepository.GetTouristRoutes();
            if (routesFromRepo == null || routesFromRepo.Count() <= 0)
            {
                return NotFound("No routes found.");
            }
            var touristRoutesDto = _mapper.Map<IEnumerable<TouristRouteDto>>(routesFromRepo);
            return Ok(touristRoutesDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetTouristRouteById(Guid id)
        {
            var tourRouteFromRepo = _touristRouteRepository.GetTouristRoute(id);
            if (tourRouteFromRepo == null)
            {
                return NotFound($"Not found route {id}.");
            }
            //var tourRouteDto = new TouristRouteDto {
            //    Id = tourRouteFromRepo.Id,
            //    Title = tourRouteFromRepo.Title,
            //    Description = tourRouteFromRepo.Description,
            //    Price = tourRouteFromRepo.OriginalPrice * (decimal)(tourRouteFromRepo.DiscountPresent ?? 1),
            //    CreateTime = tourRouteFromRepo.CreateTime,
            //    UpdateTime = tourRouteFromRepo.UpdateTime,
            //    Features = tourRouteFromRepo.Features,
            //    Fees = tourRouteFromRepo.Fees,
            //    Notes = tourRouteFromRepo.Notes,
            //    Rating = tourRouteFromRepo.Rating,
            //    TravelDays = tourRouteFromRepo.TravelDays.ToString(),
            //    TripType = tourRouteFromRepo.TripType.ToString(),
            //    DepartureCity = tourRouteFromRepo.DepartureCity.ToString(),
            //};
            var touristRouteDto = _mapper.Map<TouristRouteDto>(tourRouteFromRepo);
            return Ok(touristRouteDto);
        }
    }
}
