using SampleProject.Application.DTOs;

namespace SampleProject.Application.Contracts;

public interface IUserService
{
    Task Registration(RegistrationDTO input, CancellationToken cToken);
}