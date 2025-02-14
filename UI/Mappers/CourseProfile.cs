using AutoMapper;
using UI.Dtos.Course;
using UI.Entities;

namespace UI.Mappers;

public class CourseProfile : Profile
{
    public CourseProfile()
    {
        CreateMap<CreateCourseDto, Course>();
        CreateMap<UpdateCourseDto, Course>();
        CreateMap<Course, CourseResponseDto>()
            .ForMember(dest => dest.UniversityName, src => src.MapFrom(x => x.University.Name));
    }
}