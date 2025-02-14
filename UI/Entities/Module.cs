namespace UI.Entities;

public class Module
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public Guid CourseId { get; set; }
    public Course Course { get; set; }

    public IEnumerable<Lecture> Lectures { get; set; } = new List<Lecture>();
}