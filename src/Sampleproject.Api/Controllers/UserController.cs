using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SampleProject.Application.Usecases.User.Command.Registration;
using SampleProject.Application.Usecases.User.Query.UserList;

namespace SampleProject.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await mediator.Send(new UserListQuery());
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Insert(RegistrationCommand request, CancellationToken cToken)
    {
        await mediator.Send(request, cToken);
        return Ok();
    }
}