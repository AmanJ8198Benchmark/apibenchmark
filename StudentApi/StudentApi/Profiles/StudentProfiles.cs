using AutoMapper;
using StudentApi.DTOS;
using StudentApi.Models;

namespace StudentApi.Profiles
{
    public class StudentProfiles : Profile
    {
        public StudentProfiles() 
        {
            CreateMap<StudentProfiles, StudentReadDto>();
            CreateMap<StudentCreateDto, Student>();
            CreateMap<StudentUpdateDto, Student>();
            CreateMap<Student, StudentUpdateDto>();
        }

    }
}
