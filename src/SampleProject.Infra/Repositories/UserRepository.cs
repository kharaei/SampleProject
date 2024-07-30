using SampleProject.Domain.Entities;
using SampleProject.Domain.Repositoties;

namespace SampleProject.Infra.Repositories;

public class UserRepository(SamProDbContext _dbContext) : IUserRepository
{
    public async Task CreateAsync(UserEntity entity)
    {
        await _dbContext.Users.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }
}