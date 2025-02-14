using UI.Data;
using UI.Entities;
using UI.Interfaces;

namespace UI.Repositories;

public class ModuleRepo(AppDbContext context) : BaseRepo<Module>(context), IModuleRepo
{
    
}