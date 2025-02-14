namespace UI.Dtos.Lecture;

public class CreateLectureDto
{
    public string Topic { get; set; } = string.Empty;
    public string RecordUrl { get; set; } = string.Empty;
    public Guid ModuleId { get; set; }
}