using SampleProject.Domain.Entities;

namespace SampleProject.Domain.Repositoties;

public interface IWorkbookRepository
{
    Task CreateAsync(WorkbookEntity entity);
    Task<IEnumerable<WorkbookEntity>> ReadAllAsync();
}