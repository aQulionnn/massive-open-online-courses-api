using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UI.Dtos.Module;
using UI.Entities;
using UI.Interfaces;

namespace UI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ModuleController(IModuleRepo moduleRepo, IMapper mapper) : ControllerBase
{
    private readonly IModuleRepo _moduleRepo = moduleRepo;
    private readonly IMapper _mapper = mapper;

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateModuleDto createModuleDto)
    {
        var module = _mapper.Map<Module>(createModuleDto);
        var result = await _moduleRepo.CreateAsync(module);
        
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var modules = await _moduleRepo.GetAllAsync();
        var result = _mapper.Map<IEnumerable<ModuleResponseDto>>(modules);
        
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var module = await _moduleRepo.GetByIdAsync(id);
        if (module == null)
            return NotFound();
        
        var result = _mapper.Map<ModuleResponseDto>(module);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] UpdateModuleDto updateModuleDto)
    {
        var module = _mapper.Map<Module>(updateModuleDto);
        var result = await _moduleRepo.UpdateAsync(id, module);
        if (result == null)
            return NotFound();
        
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        var result = await _moduleRepo.DeleteAsync(id);
        if (result == null)
            return NotFound();
        
        return Ok(result);
    }
}
