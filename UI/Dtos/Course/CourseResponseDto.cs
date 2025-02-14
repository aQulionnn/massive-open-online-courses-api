namespace UI.Dtos.Course;

public class CourseResponseDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string UniversityName { get; set; } = string.Empty;
}