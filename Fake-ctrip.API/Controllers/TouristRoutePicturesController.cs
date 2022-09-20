using AutoMapper;
using Fake_ctrip.API.Dtos;
using Fake_ctrip.API.Models;
using Fake_ctrip.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Fake_ctrip.API.Controllers
{
    [Route("api/touristroutes/{touristRouteId}/pictures")]
    [ApiController]
    public class TouristRoutePicturesController : ControllerBase
    {
        private ITouristRouteRepository _touristRouteRepository;
        private IMapper _mapper;
        public TouristRoutePicturesController(ITouristRouteRepository touristRouteRepository, IMapper mapper)
        {
            _touristRouteRepository = touristRouteRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetPictureListForTouristRoute(Guid touristRouteId)
        {
            if (!_touristRouteRepository.HasTouristRoute(touristRouteId))
            {
                return NotFound("Not found tourist route.");
            }
            var picturesFromRepo = _touristRouteRepository.GetPicturesByTouristRouteId(touristRouteId);
            if (picturesFromRepo == null || picturesFromRepo.Count() == 0)
            {
                return NotFound("Not found tourist route pictures.");
            }
            var picturesDto = _mapper.Map<IEnumerable<TouristRoutePictureDto>>(picturesFromRepo);
            return Ok(picturesDto);
        }

        [HttpGet("{id}", Name = "GetPicture")]
        public IActionResult GetPicture(Guid touristRouteId, int id)
        {
            if (!_touristRouteRepository.HasTouristRoute(touristRouteId))
            {
                return NotFound("Not found tourist route.");
            }
            var pictureFromRepo = _touristRouteRepository.GetPicture(id);
            if (pictureFromRepo == null)
            {
                return NotFound("Not found picture.");
            }
            return Ok(_mapper.Map<TouristRoutePictureDto>(pictureFromRepo));
        }

        [HttpPost]
        public IActionResult CreateTouristRoutePicture(Guid touristRouteId, [FromBody] CreateTouristRoutePictureCommand command)
        {
            if (!_touristRouteRepository.HasTouristRoute(touristRouteId))
            {
                return NotFound("Not found tourist route.");
            }
            var model = _mapper.Map<TouristRoutePicture>(command);
            _touristRouteRepository.CreateTouristRoutePicture(touristRouteId, model);
            _touristRouteRepository.Save();
            var returnModel = _mapper.Map<TouristRoutePictureDto>(model);
            return CreatedAtRoute(
                "GetPicture",
                new { TouristRouteId = model.TouristRouteId, Id = model.Id },
                returnModel
            );
        }
    }
}
