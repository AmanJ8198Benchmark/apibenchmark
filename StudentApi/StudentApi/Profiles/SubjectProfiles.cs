using AutoMapper;
using StudentApi.DTOS;
using StudentApi.Models;

namespace StudentApi.Profiles
{
    public class SubjectProfiles : Profile
    {
        public SubjectProfiles()
        {
            CreateMap<SubjectProfiles, SubjectReadDto>();
            CreateMap<SubjectCreateDto, Subject>();
            CreateMap<SubjectUpdateDto, Subject>();
            CreateMap<Subject, SubjectUpdateDto>();
        }
    }
}
