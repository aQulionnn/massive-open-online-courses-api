using UI.Entities;

namespace UI.Interfaces;

public interface IModuleRepo : IBaseRepo<Module>
{
    Task<IEnumerable<Module>> GetAllAsync();
    Task<Module?> GetByIdAsync(Guid id);
}