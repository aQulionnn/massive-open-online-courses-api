using Microsoft.EntityFrameworkCore;
using UI.Data;
using UI.Entities;
using UI.Interfaces;

namespace UI.Repositories;

public class CourseRepo(AppDbContext context) : BaseRepo<Course>(context), ICourseRepo
{
    private readonly AppDbContext _context = context;

    public async Task<IEnumerable<Course>> GetAllAsync()
    {
        return await _context.Courses.Include(x => x.University).ToListAsync();
    }

    public async Task<Course?> GetByIdAsync(Guid id)
    {
        var course = await _context.Courses.Include(x => x.University).FirstOrDefaultAsync(x => x.Id == id);
        if (course == null)
            return null;
        
        return course;
    }
}