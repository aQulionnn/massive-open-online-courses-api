using UI.Entities;

namespace UI.Data;

public class CourseConfiguration
{
    public static readonly Guid CorporateLawCourseId = Guid.NewGuid();
    public static readonly Guid AiMlCourseId = Guid.NewGuid();
    public static readonly Guid QuantumComputingCourseId = Guid.NewGuid();
    
    public static IEnumerable<Course> GetData()
    {
        return new List<Course>
        {
            new Course
            {
                Id = CorporateLawCourseId,
                Title = "Corporate Law & Governance",
                Description = "An in-depth study of corporate law, governance structures, and regulatory frameworks.",
                UniversityId = UniversityConfiguration.HarvardUniversityId
            },
            new Course
            {
                Id = AiMlCourseId,
                Title = "Artificial Intelligence & Machine Learning",
                Description = "Exploring AI principles, deep learning, and real-world ML applications.",
                UniversityId = UniversityConfiguration.StanfordUniversityId
            },
            new Course
            {
                Id = QuantumComputingCourseId,
                Title = "Quantum Computing & Advanced Algorithms",
                Description = "Understanding quantum mechanics, quantum algorithms, and their applications.",
                UniversityId = UniversityConfiguration.MitUniversityId
            }
        };
    }
}