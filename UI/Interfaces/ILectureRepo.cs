using UI.Entities;

namespace UI.Interfaces;

public interface ILectureRepo : IBaseRepo<Lecture>
{
    Task<IEnumerable<Lecture>> GetAllAsync();
    Task<Lecture?> GetByIdAsync(Guid id);
}