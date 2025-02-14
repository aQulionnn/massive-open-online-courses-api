using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UI.Dtos.Lecture;
using UI.Dtos.University;
using UI.Entities;
using UI.Interfaces;

namespace UI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UniversityController(IUniversityRepo universityRepo, IMapper mapper) : ControllerBase
{
    private readonly IUniversityRepo _universityRepo = universityRepo;
    private readonly IMapper _mapper = mapper;

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateUniversityDto createUniversityDto)
    {
        var university = _mapper.Map<University>(createUniversityDto);
        var result = await _universityRepo.CreateAsync(university);
        
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var universities = await _universityRepo.GetAllAsync();
        var result = _mapper.Map<IEnumerable<UniversityResponseDto>>(universities);
        
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var university = await _universityRepo.GetByIdAsync(id);
        if (university == null)
            return NotFound();
        
        var result = _mapper.Map<UniversityResponseDto>(university);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] UpdateUniversityDto updateUniversityDto)
    {
        var university = _mapper.Map<University>(updateUniversityDto);
        var result = await _universityRepo.UpdateAsync(id, university);
        if (result == null)
            return NotFound();
        
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        var result = await _universityRepo.DeleteAsync(id);
        if (result == null)
            return NotFound();
        
        return Ok(result);
    }
}