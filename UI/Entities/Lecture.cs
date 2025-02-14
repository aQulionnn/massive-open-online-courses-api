namespace UI.Entities;

public class Lecture
{
    public Guid Id { get; set; }
    public string Topic { get; set; } = string.Empty;
    public string RecordUrl { get; set; } = string.Empty;

    public Guid ModuleId { get; set; }
    public Module Module { get; set; } = new Module();
}