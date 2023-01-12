using AutoMapper;
using StudentApi.DTOS;
using StudentApi.Models;

namespace StudentApi.Profiles
{
    public class MarksProfile : Profile
    {
        public MarksProfile()
        {
            CreateMap<MarksProfile, MarksReadDto>();
            CreateMap<MarkCreateDto, Mark>();
            CreateMap<MarksUpdateDto, Mark>();
            CreateMap<Mark, MarksUpdateDto>();
        }
    }
}
