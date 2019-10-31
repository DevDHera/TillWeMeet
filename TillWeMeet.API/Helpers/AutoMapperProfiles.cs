using AutoMapper;
using TillWeMeet.API.Dtos;
using TillWeMeet.API.Models;

namespace TillWeMeet.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>();
            CreateMap<User, UserForDetailedDto>();
        }
    }
}