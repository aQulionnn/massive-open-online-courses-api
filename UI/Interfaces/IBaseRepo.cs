namespace UI.Interfaces;

public interface IBaseRepo<T>
{
    Task<T?> CreateAsync(T createEntity);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(Guid id);
    Task<T?> UpdateAsync(Guid id, T updateEntity);
    Task<T?> DeleteAsync(Guid id);
}