namespace UI.Dtos.Module;

public class ModuleResponseDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
}