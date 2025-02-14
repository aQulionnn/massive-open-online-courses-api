namespace UI.Dtos.Lecture;

public class LectureResponseDto
{
    public Guid Id { get; set; }
    public string Topic { get; set; } = string.Empty;
    public string RecordUrl { get; set; } = string.Empty;
    public string ModuleName { get; set; } = string.Empty;
}