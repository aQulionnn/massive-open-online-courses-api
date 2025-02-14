using Microsoft.EntityFrameworkCore;
using UI.Data;
using UI.Entities;
using UI.Interfaces;

namespace UI.Repositories;

public class ModuleRepo(AppDbContext context) : BaseRepo<Module>(context), IModuleRepo
{
    private readonly AppDbContext _context = context;

    public async Task<IEnumerable<Module>> GetAllAsync()
    {
        return await _context.Modules.Include(x => x.Course).ToListAsync();
    }

    public async Task<Module?> GetByIdAsync(Guid id)
    {
        var module = await _context.Modules.Include(x => x.Course).FirstOrDefaultAsync(x => x.Id == id);
        if (module == null)
            return null;

        return module;
    }
}