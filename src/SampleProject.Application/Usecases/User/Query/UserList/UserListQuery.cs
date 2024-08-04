using MediatR;
using SampleProject.Domain.Entities;

namespace SampleProject.Application.Usecases.User.Query.UserList;

public class UserListQuery : IRequest<IEnumerable<UserListDto>>
{

}