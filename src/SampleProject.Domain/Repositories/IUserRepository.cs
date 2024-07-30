using SampleProject.Domain.Entities;

namespace SampleProject.Domain.Repositoties;

public interface IUserRepository
{
    Task CreateAsync(UserEntity entity, CancellationToken cToken);
}