namespace UI.Interfaces;

public interface IBaseRepo<T>
{
    Task<T?> CreateAsync(T createEntity);
    Task<T?> UpdateAsync(Guid id, T updateEntity);
    Task<T?> DeleteAsync(Guid id);
}