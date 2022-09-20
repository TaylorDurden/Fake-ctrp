using AutoMapper;
using Fake_ctrip.API.Dtos;
using Fake_ctrip.API.Models;

namespace Fake_ctrip.API.Profiles
{
    public class TouristRoutePictureProfile : Profile
    {
        public TouristRoutePictureProfile()
        {
            CreateMap<TouristRoutePicture, TouristRoutePictureDto>();
            CreateMap<CreateTouristRoutePictureCommand, TouristRoutePicture>();
        }
    }
}
