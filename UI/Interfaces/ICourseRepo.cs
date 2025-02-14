using UI.Entities;

namespace UI.Interfaces;

public interface ICourseRepo : IBaseRepo<Course>
{
    Task<IEnumerable<Course>> GetAllAsync();
    Task<Course?> GetByIdAsync(Guid id);
}