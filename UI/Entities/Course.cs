namespace UI.Entities;

public class Course
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public Guid UniversityId { get; set; }
    public University University { get; set; } = new University();
    
    public IEnumerable<Module> Modules { get; set; } = new List<Module>();
}