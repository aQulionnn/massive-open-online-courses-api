namespace UI.Entities;

public class University
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public IEnumerable<Course> Courses { get; set; } = new List<Course>();
}