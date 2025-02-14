using Microsoft.EntityFrameworkCore;
using UI.Data;
using UI.Interfaces;

namespace UI.Repositories;

public class BaseRepo<T>(AppDbContext context) : IBaseRepo<T>
    where T : class
{
    public async Task<T?> CreateAsync(T createEntity)
    {
        await context.Set<T>().AddAsync(createEntity);
        await context.SaveChangesAsync();
        return createEntity;
    }

    public async Task<T?> UpdateAsync(Guid id, T updateEntity)
    {
        var entity = await context.Set<T>().FindAsync(id);
        if (entity == null)
            return null;
        
        context.Entry(entity).CurrentValues.SetValues(updateEntity);
        await context.SaveChangesAsync();
        return updateEntity;
    }

    public async Task<T?> DeleteAsync(Guid id)
    {
        var entity = await context.Set<T>().FindAsync(id);
        if (entity == null)
            return null;
        
        context.Set<T>().Remove(entity);
        await context.SaveChangesAsync();
        return entity;
    }
}