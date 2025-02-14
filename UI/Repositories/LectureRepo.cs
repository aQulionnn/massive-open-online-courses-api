using Microsoft.EntityFrameworkCore;
using UI.Data;
using UI.Entities;
using UI.Interfaces;

namespace UI.Repositories;

public class LectureRepo(AppDbContext context) : BaseRepo<Lecture>(context), ILectureRepo
{
    private readonly AppDbContext _context = context;

    public async Task<IEnumerable<Lecture>> GetAllAsync()
    {
        return await _context.Lectures.Include(x => x.Module).ToListAsync();
    }

    public async Task<Lecture?> GetByIdAsync(Guid id)
    {
        var lecture = await _context.Lectures.Include(x => x.Module).FirstOrDefaultAsync(x => x.Id == id);
        if (lecture == null)
            return null;
        
        return lecture;
    }
}