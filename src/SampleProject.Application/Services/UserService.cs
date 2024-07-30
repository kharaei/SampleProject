using SampleProject.Application.Contracts;
using SampleProject.Application.DTOs;
using SampleProject.Domain.Entities;
using SampleProject.Domain.Repositoties;

namespace SampleProject.Application.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    public async Task Registration(RegistrationDTO input, CancellationToken cToken)
    {
        var newEntity = new UserEntity {
            Fullname = input.Fullname,
            Username = input.Username,
            Password = input.Password
        };
        await userRepository.CreateAsync(newEntity, cToken);
    }
}
