using MediatR;
using SampleProject.Domain.Repositoties;

namespace SampleProject.Application.Usecases.User.Query.UserList;

public class UserListQueryHandler(IUserRepository userRepository) : IRequestHandler<UserListQuery, IEnumerable<UserListDto>>
{
    public async Task<IEnumerable<UserListDto>> Handle(UserListQuery request, CancellationToken cancellationToken)
    {
        var users = await userRepository.ReadAllAsync();
        return users.Select(s => new UserListDto(s.Id, s.Username, s.Fullname));
    }
}