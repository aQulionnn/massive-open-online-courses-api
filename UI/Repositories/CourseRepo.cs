using UI.Data;
using UI.Entities;
using UI.Interfaces;

namespace UI.Repositories;

public class CourseRepo(AppDbContext context) : BaseRepo<Course>(context), ICourseRepo
{
    
}