using UI.Entities;

namespace UI.Data;

public static class ModuleConfiguration
{
    public static readonly Guid CorporateLawBasicsModuleId = Guid.NewGuid();
    public static readonly Guid CorporateRegulationsModuleId = Guid.NewGuid();

    public static readonly Guid AiFundamentalsModuleId = Guid.NewGuid();
    public static readonly Guid DeepLearningModuleId = Guid.NewGuid();

    public static readonly Guid QuantumMechanicsModuleId = Guid.NewGuid();
    public static readonly Guid QuantumAlgorithmsModuleId = Guid.NewGuid();

    public static IEnumerable<Module> GetData()
    {
        return new List<Module>
        {
            new Module
            {
                Id = CorporateLawBasicsModuleId,
                Name = "Corporate Law Basics",
                Description = "Introduction to corporate legal frameworks and governance.",
                CourseId = CourseConfiguration.CorporateLawCourseId
            },
            new Module
            {
                Id = CorporateRegulationsModuleId,
                Name = "Corporate Regulations",
                Description = "Understanding global corporate regulations and compliance.",
                CourseId = CourseConfiguration.CorporateLawCourseId
            },
            new Module
            {
                Id = AiFundamentalsModuleId,
                Name = "AI Fundamentals",
                Description = "Introduction to AI concepts, history, and key applications.",
                CourseId = CourseConfiguration.AiMlCourseId
            },
            new Module
            {
                Id = DeepLearningModuleId,
                Name = "Deep Learning",
                Description = "Exploring neural networks and deep learning architectures.",
                CourseId = CourseConfiguration.AiMlCourseId
            },
            new Module
            {
                Id = QuantumMechanicsModuleId,
                Name = "Quantum Mechanics",
                Description = "Fundamental principles of quantum physics.",
                CourseId = CourseConfiguration.QuantumComputingCourseId
            },
            new Module
            {
                Id = QuantumAlgorithmsModuleId,
                Name = "Quantum Algorithms",
                Description = "Study of quantum algorithms and their real-world applications.",
                CourseId = CourseConfiguration.QuantumComputingCourseId
            }
        };
    }
}