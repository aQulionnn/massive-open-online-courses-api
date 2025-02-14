using UI.Entities;

namespace UI.Data;

public static class UniversityConfiguration
{
    public static readonly Guid HarvardUniversityId = Guid.NewGuid();
    public static readonly Guid StanfordUniversityId = Guid.NewGuid();
    public static readonly Guid MitUniversityId = Guid.NewGuid();

    public static IEnumerable<University> GetData()
    {
        return new List<University>()
        {
            new University
            {
                Id = HarvardUniversityId,
                Name = "Harvard University",
                Description = "A prestigious Ivy League university in Cambridge, MA."
            },
            new University
            {
                Id = StanfordUniversityId,
                Name = "Stanford University",
                Description = "A top-ranked university known for innovation and research."
            },
            new University
            {
                Id = MitUniversityId,
                Name = "MIT",
                Description = "A world leader in science, engineering, and technology."
            }
        };
    }
}