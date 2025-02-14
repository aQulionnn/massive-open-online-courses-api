using UI.Data;
using UI.Entities;
using UI.Interfaces;

namespace UI.Repositories;

public class LectureRepo(AppDbContext context) : BaseRepo<Lecture>(context), ILectureRepo
{
    
}