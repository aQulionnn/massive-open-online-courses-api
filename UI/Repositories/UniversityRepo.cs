using UI.Data;
using UI.Entities;
using UI.Interfaces;

namespace UI.Repositories;

public class UniversityRepo(AppDbContext context) : BaseRepo<University>(context), IUniversityRepo
{
    
}