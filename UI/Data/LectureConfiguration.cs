using UI.Entities;

namespace UI.Data;

public static class LectureConfiguration
{
    public static readonly Guid CorporateLawIntroLectureId = Guid.NewGuid();
    public static readonly Guid CorporateRegulationsLectureId = Guid.NewGuid();

    public static readonly Guid AiHistoryLectureId = Guid.NewGuid();
    public static readonly Guid DeepLearningBasicsLectureId = Guid.NewGuid();

    public static readonly Guid QuantumPhysicsLectureId = Guid.NewGuid();
    public static readonly Guid QuantumAlgorithmsLectureId = Guid.NewGuid();

    public static IEnumerable<Lecture> GetData()
    {
        return new List<Lecture>
        {
            new Lecture
            {
                Id = CorporateLawIntroLectureId,
                Topic = "Introduction to Corporate Law",
                RecordUrl = "https://example.com/corporate-law-intro",
                ModuleId = ModuleConfiguration.CorporateLawBasicsModuleId
            },
            new Lecture
            {
                Id = CorporateRegulationsLectureId,
                Topic = "Understanding Corporate Regulations",
                RecordUrl = "https://example.com/corporate-regulations",
                ModuleId = ModuleConfiguration.CorporateRegulationsModuleId
            },
            new Lecture
            {
                Id = AiHistoryLectureId,
                Topic = "History of AI",
                RecordUrl = "https://example.com/ai-history",
                ModuleId = ModuleConfiguration.AiFundamentalsModuleId
            },
            new Lecture
            {
                Id = DeepLearningBasicsLectureId,
                Topic = "Basics of Deep Learning",
                RecordUrl = "https://example.com/deep-learning-basics",
                ModuleId = ModuleConfiguration.DeepLearningModuleId
            },
            new Lecture
            {
                Id = QuantumPhysicsLectureId,
                Topic = "Fundamentals of Quantum Physics",
                RecordUrl = "https://example.com/quantum-physics",
                ModuleId = ModuleConfiguration.QuantumMechanicsModuleId
            },
            new Lecture
            {
                Id = QuantumAlgorithmsLectureId,
                Topic = "Introduction to Quantum Algorithms",
                RecordUrl = "https://example.com/quantum-algorithms",
                ModuleId = ModuleConfiguration.QuantumAlgorithmsModuleId
            }
        };
    }
}
