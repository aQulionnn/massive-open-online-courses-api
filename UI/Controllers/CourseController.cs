using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UI.Dtos.Course;
using UI.Entities;
using UI.Interfaces;

namespace UI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CourseController(ICourseRepo courseRepo, IMapper mapper) : ControllerBase
{
    private readonly ICourseRepo _courseRepo = courseRepo;
    private readonly IMapper _mapper = mapper;

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateCourseDto createCourseDto)
    {
        var course = _mapper.Map<Course>(createCourseDto);
        var result = await _courseRepo.CreateAsync(course);
        
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var courses = await _courseRepo.GetAllAsync();
        var result = _mapper.Map<IEnumerable<CourseResponseDto>>(courses);
        
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var course = await _courseRepo.GetByIdAsync(id);
        if (course == null)
            return NotFound();
        
        var result = _mapper.Map<CourseResponseDto>(course);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] UpdateCourseDto updateCourseDto)
    {
        var course = _mapper.Map<Course>(updateCourseDto);
        var result = await _courseRepo.UpdateAsync(id, course);
        if (result == null)
            return NotFound();
        
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        var result = await _courseRepo.DeleteAsync(id);
        if (result == null)
            return NotFound();
        
        return Ok(result);
    }
}
