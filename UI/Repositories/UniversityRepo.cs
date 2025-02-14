using Microsoft.EntityFrameworkCore;
using UI.Data;
using UI.Entities;
using UI.Interfaces;

namespace UI.Repositories;

public class UniversityRepo(AppDbContext context) : BaseRepo<University>(context), IUniversityRepo
{
    private readonly AppDbContext _context = context;

    public async Task<IEnumerable<University>> GetAllAsync()
    {
        return await _context.Universities.ToListAsync();
    }

    public async Task<University?> GetByIdAsync(Guid id)
    {
        var university = await _context.Universities.FindAsync(id);
        if (university == null)
            return null;
        
        return university;
    }
}