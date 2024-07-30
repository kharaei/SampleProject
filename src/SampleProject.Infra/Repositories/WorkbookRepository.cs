using SampleProject.Domain.Entities;
using SampleProject.Domain.Repositoties;

namespace SampleProject.Infra.Repositories;

public class WorkbookRepository(SamProDbContext _dbContext) : IWorkbookRepository
{
    public async Task CreateAsync(WorkbookEntity entity)
    {
        await _dbContext.Workbook.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }
}