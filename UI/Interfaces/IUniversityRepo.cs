using UI.Entities;

namespace UI.Interfaces;

public interface IUniversityRepo : IBaseRepo<University>
{
    Task<IEnumerable<University>> GetAllAsync();
    Task<University?> GetByIdAsync(Guid id);
}