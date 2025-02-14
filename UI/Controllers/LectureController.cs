using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UI.Dtos.Lecture;
using UI.Entities;
using UI.Interfaces;

namespace UI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LectureController(ILectureRepo lectureRepo, IMapper mapper) : ControllerBase
{
    private readonly ILectureRepo _lectureRepo = lectureRepo;
    private readonly IMapper _mapper = mapper;

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateLectureDto createLectureDto)
    {
        var lecture = _mapper.Map<Lecture>(createLectureDto);
        var result = await _lectureRepo.CreateAsync(lecture);
        
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var lectures = await _lectureRepo.GetAllAsync();
        var result = _mapper.Map<IEnumerable<LectureResponseDto>>(lectures);
        
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var lecture = await _lectureRepo.GetByIdAsync(id);
        if (lecture == null)
            return NotFound();
        
        var result = _mapper.Map<LectureResponseDto>(lecture);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] UpdateLectureDto updateLectureDto)
    {
        var lecture = _mapper.Map<Lecture>(updateLectureDto);
        var result = await _lectureRepo.UpdateAsync(id, lecture);
        if (result == null)
            return NotFound();
        
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        var result = await _lectureRepo.DeleteAsync(id);
        if (result == null)
            return NotFound();
        
        return Ok(result);
    }
}
