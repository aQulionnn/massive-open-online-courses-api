using AutoMapper;
using UI.Dtos.Module;
using UI.Entities;

namespace UI.Mappers;

public class ModuleProfile : Profile
{
    public ModuleProfile()
    {
        CreateMap<CreateModuleDto, Module>();
        CreateMap<UpdateModuleDto, Module>();
        CreateMap<Module, ModuleResponseDto>()
            .ForMember(dest => dest.CourseName, src => src.MapFrom(x => x.Name));
    }
}