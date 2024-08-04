using MediatR;
using SampleProject.Domain.Entities;
using SampleProject.Domain.Repositoties;

namespace SampleProject.Application.Usecases.User.Command.Registration;

public class RegistrationCommandHandler(IUserRepository userRepository) : IRequestHandler<RegistrationCommand, int>
{
    public async Task<int> Handle(RegistrationCommand request, CancellationToken cToken)
    {
        var newEntity = new UserEntity {
            Fullname = request.Fullname,
            Username = request.Username,
            Password = request.Password
        };

        await userRepository.CreateAsync(newEntity, cToken);
        return newEntity.Id;
    }
}