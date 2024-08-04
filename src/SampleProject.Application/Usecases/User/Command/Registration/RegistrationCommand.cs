using MediatR;

namespace SampleProject.Application.Usecases.User.Command.Registration;

public class RegistrationCommand : IRequest<int>
{
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? PasswordConfirm { get; set; }
    public string? Fullname { get; set; }
}