using AutoMapper;
using UI.Dtos.Lecture;
using UI.Entities;

namespace UI.Mappers;

public class LectureProfile : Profile
{
    public LectureProfile()
    {
        CreateMap<CreateLectureDto, Lecture>();
        CreateMap<UpdateLectureDto, Lecture>();
        CreateMap<Lecture, LectureResponseDto>()
            .ForMember(dest => dest.ModuleName, src => src.MapFrom(x => x.Module.Name));
    }
}