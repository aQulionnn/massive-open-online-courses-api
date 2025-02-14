using AutoMapper;
using UI.Dtos.University;
using UI.Entities;

namespace UI.Mappers;

public class UniversityProfile : Profile
{
    public UniversityProfile()
    {
        CreateMap<CreateUniversityDto, University>();
        CreateMap<UpdateUniversityDto, University>();
        CreateMap<University, UniversityResponseDto>();
    }
}